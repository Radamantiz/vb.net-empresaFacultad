Public Class FrmEmpleados
    Dim objEMP As New Empleados

    Private Sub bGrabar_Click(sender As System.Object, e As System.EventArgs) Handles bGrabar.Click
        If Not objEMP.Grabar(Val(txtDni.Text), txtNombre.Text, Val(txtSueldo.Text)) Then
            MsgBox("dni repetido")
        Else
            txtNombre.Text = ""
            txtSueldo.Text = ""
        End If
        txtDni.Focus()
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        Dim Fila As DataRow = objEMP.Buscar(Val(txtDni.Text))
        If Fila Is Nothing Then
            MsgBox("Registro no encontrado")
        Else
            txtNombre.Text = Fila("nombre")
            txtSueldo.Text = Fila("sueldo")
        End If
    End Sub

    Private Sub bEliminar_Click(sender As System.Object, e As System.EventArgs) Handles bEliminar.Click
        objEMP.eliminar(Val(txtDni.Text))
        txtNombre.Text = ""
        txtSueldo.Text = ""

    End Sub

    Private Sub bModificar_Click(sender As System.Object, e As System.EventArgs) Handles bModificar.Click
        objEMP.modificar(Val(txtDni.Text), txtNombre.Text, Val(txtSueldo.Text))
    End Sub

    Private Sub FrmEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
