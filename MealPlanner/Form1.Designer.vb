<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtCalorieInput = New System.Windows.Forms.TextBox()
        Me.lblCalorieInput = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCalorieInput
        '
        Me.txtCalorieInput.Location = New System.Drawing.Point(223, 148)
        Me.txtCalorieInput.Name = "txtCalorieInput"
        Me.txtCalorieInput.Size = New System.Drawing.Size(100, 20)
        Me.txtCalorieInput.TabIndex = 1
        '
        'lblCalorieInput
        '
        Me.lblCalorieInput.AutoSize = True
        Me.lblCalorieInput.Location = New System.Drawing.Point(57, 151)
        Me.lblCalorieInput.Name = "lblCalorieInput"
        Me.lblCalorieInput.Size = New System.Drawing.Size(143, 13)
        Me.lblCalorieInput.TabIndex = 2
        Me.lblCalorieInput.Text = "Maximum number of calories:"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(370, 145)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOutput.Location = New System.Drawing.Point(538, 148)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(37, 13)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "(Food)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblCalorieInput)
        Me.Controls.Add(Me.txtCalorieInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCalorieInput As TextBox
    Friend WithEvents lblCalorieInput As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents lblOutput As Label
End Class
