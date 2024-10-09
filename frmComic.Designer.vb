<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComic
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
        picComic = New PictureBox()
        lblHeading = New Label()
        lblGroupSize = New Label()
        lblRegCost = New Label()
        lblCost = New Label()
        txtSize = New TextBox()
        grpComicType = New GroupBox()
        radConvention = New RadioButton()
        radAutograph = New RadioButton()
        radSuperhero = New RadioButton()
        btnCalculate = New Button()
        btnClear = New Button()
        CType(picComic, ComponentModel.ISupportInitialize).BeginInit()
        grpComicType.SuspendLayout()
        SuspendLayout()
        ' 
        ' picComic
        ' 
        picComic.Image = My.Resources.Resources.comic
        picComic.Location = New Point(2, 0)
        picComic.Name = "picComic"
        picComic.Size = New Size(514, 182)
        picComic.SizeMode = PictureBoxSizeMode.StretchImage
        picComic.TabIndex = 0
        picComic.TabStop = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(100, 200)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(316, 30)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Comic Convention Registration"
        ' 
        ' lblGroupSize
        ' 
        lblGroupSize.AutoSize = True
        lblGroupSize.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        lblGroupSize.Location = New Point(185, 258)
        lblGroupSize.Name = "lblGroupSize"
        lblGroupSize.Size = New Size(101, 23)
        lblGroupSize.TabIndex = 2
        lblGroupSize.Text = "Group Size:"
        ' 
        ' lblRegCost
        ' 
        lblRegCost.AutoSize = True
        lblRegCost.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        lblRegCost.Location = New Point(141, 454)
        lblRegCost.Name = "lblRegCost"
        lblRegCost.Size = New Size(151, 23)
        lblRegCost.TabIndex = 3
        lblRegCost.Text = "Registration Cost:"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        lblCost.Location = New Point(332, 454)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(44, 23)
        lblCost.TabIndex = 4
        lblCost.Text = "Cost"
        ' 
        ' txtSize
        ' 
        txtSize.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        txtSize.ForeColor = Color.Tomato
        txtSize.Location = New Point(300, 255)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(31, 30)
        txtSize.TabIndex = 5
        txtSize.TextAlign = HorizontalAlignment.Center
        ' 
        ' grpComicType
        ' 
        grpComicType.BackColor = Color.Turquoise
        grpComicType.Controls.Add(radConvention)
        grpComicType.Controls.Add(radAutograph)
        grpComicType.Controls.Add(radSuperhero)
        grpComicType.Font = New Font("Castellar", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpComicType.ForeColor = Color.Tomato
        grpComicType.Location = New Point(71, 299)
        grpComicType.Name = "grpComicType"
        grpComicType.Size = New Size(375, 125)
        grpComicType.TabIndex = 6
        grpComicType.TabStop = False
        grpComicType.Text = "Select Badge Type:"
        ' 
        ' radConvention
        ' 
        radConvention.AutoSize = True
        radConvention.Checked = True
        radConvention.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        radConvention.Location = New Point(40, 83)
        radConvention.Name = "radConvention"
        radConvention.Size = New Size(111, 22)
        radConvention.TabIndex = 2
        radConvention.TabStop = True
        radConvention.Text = "Convention"
        radConvention.UseVisualStyleBackColor = True
        ' 
        ' radAutograph
        ' 
        radAutograph.AutoSize = True
        radAutograph.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        radAutograph.Location = New Point(40, 55)
        radAutograph.Name = "radAutograph"
        radAutograph.Size = New Size(206, 22)
        radAutograph.TabIndex = 1
        radAutograph.Text = "Convention + Autograph"
        radAutograph.UseVisualStyleBackColor = True
        ' 
        ' radSuperhero
        ' 
        radSuperhero.AutoSize = True
        radSuperhero.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        radSuperhero.Location = New Point(40, 27)
        radSuperhero.Name = "radSuperhero"
        radSuperhero.Size = New Size(292, 22)
        radSuperhero.TabIndex = 0
        radSuperhero.Text = "Convention + Superhero Experience"
        radSuperhero.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Turquoise
        btnCalculate.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold)
        btnCalculate.ForeColor = Color.Black
        btnCalculate.Location = New Point(130, 495)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(106, 32)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Turquoise
        btnClear.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold)
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(280, 495)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 32)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' frmComic
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(516, 589)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(grpComicType)
        Controls.Add(txtSize)
        Controls.Add(lblCost)
        Controls.Add(lblRegCost)
        Controls.Add(lblGroupSize)
        Controls.Add(lblHeading)
        Controls.Add(picComic)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Tomato
        Name = "frmComic"
        Text = "Comic Convention Registration"
        CType(picComic, ComponentModel.ISupportInitialize).EndInit()
        grpComicType.ResumeLayout(False)
        grpComicType.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents lblRegCost As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents grpComicType As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutograph As RadioButton
    Friend WithEvents radSuperhero As RadioButton

End Class
