<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiceForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiceForm))
        Me.btnRollDFour = New System.Windows.Forms.Button()
        Me.CalcLabel = New System.Windows.Forms.Label()
        Me.btnRollDSix = New System.Windows.Forms.Button()
        Me.btnRollDEight = New System.Windows.Forms.Button()
        Me.btnRollDTen = New System.Windows.Forms.Button()
        Me.btnRollDTwelve = New System.Windows.Forms.Button()
        Me.btnRollDTwenty = New System.Windows.Forms.Button()
        Me.btnRollDHundred = New System.Windows.Forms.Button()
        Me.YouRolled = New System.Windows.Forms.Label()
        Me.dicePool = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
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
        Me.CalcLabel.Font = New System.Drawing.Font("Quicksand", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CalcLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.CalcLabel.Location = New System.Drawing.Point(416, 20)
        Me.CalcLabel.Name = "CalcLabel"
        Me.CalcLabel.Size = New System.Drawing.Size(34, 40)
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
        'YouRolled
        '
        Me.YouRolled.AutoSize = True
        Me.YouRolled.Font = New System.Drawing.Font("Quicksand", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.YouRolled.ForeColor = System.Drawing.SystemColors.Control
        Me.YouRolled.Location = New System.Drawing.Point(306, 30)
        Me.YouRolled.Name = "YouRolled"
        Me.YouRolled.Size = New System.Drawing.Size(115, 28)
        Me.YouRolled.TabIndex = 8
        Me.YouRolled.Text = "You Rolled:"
        '
        'dicePool
        '
        Me.dicePool.BackColor = System.Drawing.Color.MintCream
        Me.dicePool.Location = New System.Drawing.Point(333, 64)
        Me.dicePool.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dicePool.Name = "dicePool"
        Me.dicePool.Size = New System.Drawing.Size(102, 28)
        Me.dicePool.TabIndex = 9
        Me.dicePool.Text = "Roll Multiple"
        Me.dicePool.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.MintCream
        Me.btnAdd.Location = New System.Drawing.Point(525, 30)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(34, 28)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseCompatibleTextRendering = True
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.MintCream
        Me.btnSub.Location = New System.Drawing.Point(485, 30)
        Me.btnSub.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(34, 28)
        Me.btnSub.TabIndex = 11
        Me.btnSub.Text = "-"
        Me.btnSub.UseCompatibleTextRendering = True
        Me.btnSub.UseVisualStyleBackColor = False
        '
        'DiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 540)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dicePool)
        Me.Controls.Add(Me.YouRolled)
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
    Friend WithEvents YouRolled As Label
    Friend WithEvents dicePool As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSub As Button
End Class
