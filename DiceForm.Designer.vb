<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiceForm))
        Me.btnRollDFour = New System.Windows.Forms.Button()
        Me.CalcLabel = New System.Windows.Forms.Label()
        Me.btnRollDSix = New System.Windows.Forms.Button()
        Me.btnRollDEight = New System.Windows.Forms.Button()
        Me.btnRollDTen = New System.Windows.Forms.Button()
        Me.btnRollDTwelve = New System.Windows.Forms.Button()
        Me.btnRollDTwenty = New System.Windows.Forms.Button()
        Me.btnRollDHundred = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRollDFour
        '
        Me.btnRollDFour.BackColor = System.Drawing.Color.MintCream
        Me.btnRollDFour.Location = New System.Drawing.Point(12, 172)
        Me.btnRollDFour.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRollDFour.Name = "btnRollDFour"
        Me.btnRollDFour.Size = New System.Drawing.Size(75, 28)
        Me.btnRollDFour.TabIndex = 0
        Me.btnRollDFour.Text = "Roll 1d4"
        Me.btnRollDFour.UseVisualStyleBackColor = False
        '
        'CalcLabel
        '
        Me.CalcLabel.AutoSize = True
        Me.CalcLabel.BackColor = System.Drawing.Color.Transparent
        Me.CalcLabel.Font = New System.Drawing.Font("Quicksand", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CalcLabel.Location = New System.Drawing.Point(367, 55)
        Me.CalcLabel.Name = "CalcLabel"
        Me.CalcLabel.Size = New System.Drawing.Size(33, 40)
        Me.CalcLabel.TabIndex = 1
        Me.CalcLabel.Text = "0"
        '
        'btnRollDSix
        '
        Me.btnRollDSix.BackColor = System.Drawing.Color.MintCream
        Me.btnRollDSix.Location = New System.Drawing.Point(12, 208)
        Me.btnRollDSix.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRollDSix.Name = "btnRollDSix"
        Me.btnRollDSix.Size = New System.Drawing.Size(75, 28)
        Me.btnRollDSix.TabIndex = 2
        Me.btnRollDSix.Text = "Roll 1d6"
        Me.btnRollDSix.UseVisualStyleBackColor = False
        '
        'btnRollDEight
        '
        Me.btnRollDEight.BackColor = System.Drawing.Color.MintCream
        Me.btnRollDEight.Location = New System.Drawing.Point(12, 244)
        Me.btnRollDEight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRollDEight.Name = "btnRollDEight"
        Me.btnRollDEight.Size = New System.Drawing.Size(75, 28)
        Me.btnRollDEight.TabIndex = 3
        Me.btnRollDEight.Text = "Roll 1d8"
        Me.btnRollDEight.UseVisualStyleBackColor = False
        '
        'btnRollDTen
        '
        Me.btnRollDTen.BackColor = System.Drawing.Color.MintCream
        Me.btnRollDTen.Location = New System.Drawing.Point(12, 280)
        Me.btnRollDTen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRollDTen.Name = "btnRollDTen"
        Me.btnRollDTen.Size = New System.Drawing.Size(75, 28)
        Me.btnRollDTen.TabIndex = 4
        Me.btnRollDTen.Text = "Roll 1d10"
        Me.btnRollDTen.UseVisualStyleBackColor = False
        '
        'btnRollDTwelve
        '
        Me.btnRollDTwelve.BackColor = System.Drawing.Color.MintCream
        Me.btnRollDTwelve.Location = New System.Drawing.Point(12, 316)
        Me.btnRollDTwelve.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRollDTwelve.Name = "btnRollDTwelve"
        Me.btnRollDTwelve.Size = New System.Drawing.Size(75, 28)
        Me.btnRollDTwelve.TabIndex = 5
        Me.btnRollDTwelve.Text = "Roll 1d12"
        Me.btnRollDTwelve.UseVisualStyleBackColor = False
        '
        'btnRollDTwenty
        '
        Me.btnRollDTwenty.BackColor = System.Drawing.Color.MintCream
        Me.btnRollDTwenty.Location = New System.Drawing.Point(12, 352)
        Me.btnRollDTwenty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRollDTwenty.Name = "btnRollDTwenty"
        Me.btnRollDTwenty.Size = New System.Drawing.Size(75, 28)
        Me.btnRollDTwenty.TabIndex = 6
        Me.btnRollDTwenty.Text = "Roll 1d20"
        Me.btnRollDTwenty.UseVisualStyleBackColor = False
        '
        'btnRollDHundred
        '
        Me.btnRollDHundred.BackColor = System.Drawing.Color.MintCream
        Me.btnRollDHundred.Location = New System.Drawing.Point(12, 388)
        Me.btnRollDHundred.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRollDHundred.Name = "btnRollDHundred"
        Me.btnRollDHundred.Size = New System.Drawing.Size(75, 28)
        Me.btnRollDHundred.TabIndex = 7
        Me.btnRollDHundred.Text = "Roll 1d100"
        Me.btnRollDHundred.UseVisualStyleBackColor = False
        '
        'DiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 540)
        Me.Controls.Add(Me.btnRollDHundred)
        Me.Controls.Add(Me.btnRollDTwenty)
        Me.Controls.Add(Me.btnRollDTwelve)
        Me.Controls.Add(Me.btnRollDTen)
        Me.Controls.Add(Me.btnRollDEight)
        Me.Controls.Add(Me.btnRollDSix)
        Me.Controls.Add(Me.CalcLabel)
        Me.Controls.Add(Me.btnRollDFour)
        Me.Font = New System.Drawing.Font("Quicksand", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DiceForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Dice Roller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRollDFour As Button
    Friend WithEvents CalcLabel As Label
    Friend WithEvents btnRollDSix As Button
    Friend WithEvents btnRollDEight As Button
    Friend WithEvents btnRollDTen As Button
    Friend WithEvents btnRollDTwelve As Button
    Friend WithEvents btnRollDTwenty As Button
    Friend WithEvents btnRollDHundred As Button
End Class
