<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.player_name = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.player_points = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(279, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "00:00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(279, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(-1, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Players Name:"
        '
        'player_name
        '
        Me.player_name.AutoSize = True
        Me.player_name.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.player_name.Location = New System.Drawing.Point(-1, 73)
        Me.player_name.Name = "player_name"
        Me.player_name.Size = New System.Drawing.Size(62, 25)
        Me.player_name.TabIndex = 3
        Me.player_name.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(551, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 36)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Points:"
        '
        'player_points
        '
        Me.player_points.AutoSize = True
        Me.player_points.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.player_points.Location = New System.Drawing.Point(594, 59)
        Me.player_points.Name = "player_points"
        Me.player_points.Size = New System.Drawing.Size(59, 72)
        Me.player_points.TabIndex = 5
        Me.player_points.Text = "0"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.player_points)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.player_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents player_name As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents player_points As Label
End Class
