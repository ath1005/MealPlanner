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
        Me.btnMaxCalOK = New System.Windows.Forms.Button()
        Me.lblMaxCalOutput = New System.Windows.Forms.Label()
        Me.lblFoodSearch = New System.Windows.Forms.Label()
        Me.txtFoodSearch = New System.Windows.Forms.TextBox()
        Me.btnFoodSearch = New System.Windows.Forms.Button()
        Me.lblCalorieOutput = New System.Windows.Forms.Label()
        Me.lblProteinOutput = New System.Windows.Forms.Label()
        Me.lblCarbOutput = New System.Windows.Forms.Label()
        Me.lblFatOutput = New System.Windows.Forms.Label()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblProtein = New System.Windows.Forms.Label()
        Me.lblCarb = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCalorieInput
        '
        Me.txtCalorieInput.Location = New System.Drawing.Point(214, 31)
        Me.txtCalorieInput.Name = "txtCalorieInput"
        Me.txtCalorieInput.Size = New System.Drawing.Size(100, 20)
        Me.txtCalorieInput.TabIndex = 1
        '
        'lblCalorieInput
        '
        Me.lblCalorieInput.AutoSize = True
        Me.lblCalorieInput.Location = New System.Drawing.Point(38, 38)
        Me.lblCalorieInput.Name = "lblCalorieInput"
        Me.lblCalorieInput.Size = New System.Drawing.Size(143, 13)
        Me.lblCalorieInput.TabIndex = 2
        Me.lblCalorieInput.Text = "Maximum number of calories:"
        '
        'btnMaxCalOK
        '
        Me.btnMaxCalOK.Location = New System.Drawing.Point(361, 31)
        Me.btnMaxCalOK.Name = "btnMaxCalOK"
        Me.btnMaxCalOK.Size = New System.Drawing.Size(75, 23)
        Me.btnMaxCalOK.TabIndex = 3
        Me.btnMaxCalOK.Text = "OK"
        Me.btnMaxCalOK.UseVisualStyleBackColor = True
        '
        'lblMaxCalOutput
        '
        Me.lblMaxCalOutput.AutoSize = True
        Me.lblMaxCalOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMaxCalOutput.Location = New System.Drawing.Point(526, 31)
        Me.lblMaxCalOutput.Name = "lblMaxCalOutput"
        Me.lblMaxCalOutput.Size = New System.Drawing.Size(40, 13)
        Me.lblMaxCalOutput.TabIndex = 4
        Me.lblMaxCalOutput.Text = " (Food)"
        '
        'lblFoodSearch
        '
        Me.lblFoodSearch.AutoSize = True
        Me.lblFoodSearch.Location = New System.Drawing.Point(51, 223)
        Me.lblFoodSearch.Name = "lblFoodSearch"
        Me.lblFoodSearch.Size = New System.Drawing.Size(130, 13)
        Me.lblFoodSearch.TabIndex = 5
        Me.lblFoodSearch.Text = "Enter a food to search for:"
        '
        'txtFoodSearch
        '
        Me.txtFoodSearch.Location = New System.Drawing.Point(214, 223)
        Me.txtFoodSearch.Name = "txtFoodSearch"
        Me.txtFoodSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtFoodSearch.TabIndex = 6
        '
        'btnFoodSearch
        '
        Me.btnFoodSearch.Location = New System.Drawing.Point(361, 220)
        Me.btnFoodSearch.Name = "btnFoodSearch"
        Me.btnFoodSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnFoodSearch.TabIndex = 7
        Me.btnFoodSearch.Text = "Search"
        Me.btnFoodSearch.UseVisualStyleBackColor = True
        '
        'lblCalorieOutput
        '
        Me.lblCalorieOutput.AutoSize = True
        Me.lblCalorieOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCalorieOutput.Location = New System.Drawing.Point(625, 226)
        Me.lblCalorieOutput.Name = "lblCalorieOutput"
        Me.lblCalorieOutput.Size = New System.Drawing.Size(50, 13)
        Me.lblCalorieOutput.TabIndex = 8
        Me.lblCalorieOutput.Text = "(Calories)"
        '
        'lblProteinOutput
        '
        Me.lblProteinOutput.AutoSize = True
        Me.lblProteinOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblProteinOutput.Location = New System.Drawing.Point(625, 259)
        Me.lblProteinOutput.Name = "lblProteinOutput"
        Me.lblProteinOutput.Size = New System.Drawing.Size(46, 13)
        Me.lblProteinOutput.TabIndex = 9
        Me.lblProteinOutput.Text = "(Protein)"
        '
        'lblCarbOutput
        '
        Me.lblCarbOutput.AutoSize = True
        Me.lblCarbOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCarbOutput.Location = New System.Drawing.Point(625, 296)
        Me.lblCarbOutput.Name = "lblCarbOutput"
        Me.lblCarbOutput.Size = New System.Drawing.Size(81, 13)
        Me.lblCarbOutput.TabIndex = 10
        Me.lblCarbOutput.Text = "(Carbohydrates)"
        '
        'lblFatOutput
        '
        Me.lblFatOutput.AutoSize = True
        Me.lblFatOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFatOutput.Location = New System.Drawing.Point(625, 328)
        Me.lblFatOutput.Name = "lblFatOutput"
        Me.lblFatOutput.Size = New System.Drawing.Size(28, 13)
        Me.lblFatOutput.TabIndex = 11
        Me.lblFatOutput.Text = "(Fat)"
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCalories.Location = New System.Drawing.Point(526, 225)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(44, 13)
        Me.lblCalories.TabIndex = 12
        Me.lblCalories.Text = "Calories"
        '
        'lblProtein
        '
        Me.lblProtein.AutoSize = True
        Me.lblProtein.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblProtein.Location = New System.Drawing.Point(526, 259)
        Me.lblProtein.Name = "lblProtein"
        Me.lblProtein.Size = New System.Drawing.Size(55, 13)
        Me.lblProtein.TabIndex = 13
        Me.lblProtein.Text = "Protein (g)"
        '
        'lblCarb
        '
        Me.lblCarb.AutoSize = True
        Me.lblCarb.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCarb.Location = New System.Drawing.Point(526, 296)
        Me.lblCarb.Name = "lblCarb"
        Me.lblCarb.Size = New System.Drawing.Size(85, 13)
        Me.lblCarb.TabIndex = 14
        Me.lblCarb.Text = "Carbohydrate (g)"
        '
        'lblFat
        '
        Me.lblFat.AutoSize = True
        Me.lblFat.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFat.Location = New System.Drawing.Point(526, 328)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(37, 13)
        Me.lblFat.TabIndex = 15
        Me.lblFat.Text = "Fat (g)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCarb)
        Me.Controls.Add(Me.lblProtein)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.lblFatOutput)
        Me.Controls.Add(Me.lblCarbOutput)
        Me.Controls.Add(Me.lblProteinOutput)
        Me.Controls.Add(Me.lblCalorieOutput)
        Me.Controls.Add(Me.btnFoodSearch)
        Me.Controls.Add(Me.txtFoodSearch)
        Me.Controls.Add(Me.lblFoodSearch)
        Me.Controls.Add(Me.lblMaxCalOutput)
        Me.Controls.Add(Me.btnMaxCalOK)
        Me.Controls.Add(Me.lblCalorieInput)
        Me.Controls.Add(Me.txtCalorieInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCalorieInput As TextBox
    Friend WithEvents lblCalorieInput As Label
    Friend WithEvents btnMaxCalOK As Button
    Friend WithEvents lblMaxCalOutput As Label
    Friend WithEvents lblFoodSearch As Label
    Friend WithEvents txtFoodSearch As TextBox
    Friend WithEvents btnFoodSearch As Button
    Friend WithEvents lblCalorieOutput As Label
    Friend WithEvents lblProteinOutput As Label
    Friend WithEvents lblCarbOutput As Label
    Friend WithEvents lblFatOutput As Label
    Friend WithEvents lblCalories As Label
    Friend WithEvents lblProtein As Label
    Friend WithEvents lblCarb As Label
    Friend WithEvents lblFat As Label
End Class
