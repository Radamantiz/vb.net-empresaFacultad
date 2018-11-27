
Imports System.Data.OleDb


Public Class Empleados

    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Empleados"
        ADAPTADOR.Fill(TABLA)

        Dim VEC(1) As DataColumn
        VEC(0) = TABLA.Columns("dni")
        TABLA.PrimaryKey = VEC

    End Sub

    Public Function Buscar(DNI As Long) As DataRow
        Dim FILA As DataRow = TABLA.Rows.Find(DNI)
        Return FILA
    End Function

    Public Sub eliminar(DNI As Long)
        Dim FILA As DataRow = TABLA.Rows.Find(DNI)
        If Not FILA Is Nothing Then
            FILA.Delete()
            actualizar()
        Else
            MsgBox("no existe")
        End If

    End Sub

    Public Sub actualizar()
        Dim MAGICO As New OleDbCommandBuilder(ADAPTADOR)
        ADAPTADOR.Update(TABLA)
    End Sub

    Public Function Grabar(DNI As Long, NOMBRE As String, SUELDO As Decimal) As Boolean

        Dim FILA As DataRow = TABLA.Rows.Find(DNI)
        If FILA Is Nothing Then
            FILA = TABLA.NewRow
            FILA("dni") = DNI
            FILA("nombre") = NOMBRE
            FILA("sueldo") = SUELDO
            TABLA.Rows.Add(FILA)
            actualizar()
            Return True
        End If
        Return False
    End Function

    Public Sub modificar(DNI As Long, nombre As String, sueldo As Decimal)
        Dim FILA As DataRow = Buscar(DNI)

        If Not FILA Is Nothing Then
            FILA.BeginEdit()
            FILA("nombre") = nombre
            FILA("sueldo") = sueldo
            FILA.EndEdit()
            actualizar()

        End If

    End Sub


End Class
