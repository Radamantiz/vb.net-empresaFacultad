<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.bGrabar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(141, 55)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(141, 97)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(439, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SUELDO"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(141, 138)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 5
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(141, 192)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bBuscar.TabIndex = 6
        Me.bBuscar.Text = "BUSCAR"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'bGrabar
        '
        Me.bGrabar.Location = New System.Drawing.Point(267, 192)
        Me.bGrabar.Name = "bGrabar"
        Me.bGrabar.Size = New System.Drawing.Size(75, 23)
        Me.bGrabar.TabIndex = 7
        Me.bGrabar.Text = "GRABAR"
        Me.bGrabar.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Location = New System.Drawing.Point(387, 192)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(75, 23)
        Me.bEliminar.TabIndex = 8
        Me.bEliminar.Text = "ELIMINAR"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Location = New System.Drawing.Point(505, 192)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(75, 23)
        Me.bModificar.TabIndex = 9
        Me.bModificar.Text = "MODIFICAR"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 276)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.bEliminar)
        Me.Controls.Add(Me.bGrabar)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmEmpleados"
        Me.Text = "ADMINISTRAR EMPLEADOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSueldo As System.Windows.Forms.TextBox
    Friend WithEvents bBuscar As System.Windows.Forms.Button
    Friend WithEvents bGrabar As System.Windows.Forms.Button
    Friend WithEvents bEliminar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button

End Class
