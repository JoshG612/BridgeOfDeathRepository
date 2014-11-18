<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNameGuess = New System.Windows.Forms.TextBox()
        Me.txtQuestGuess = New System.Windows.Forms.TextBox()
        Me.txtColorGuess = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQ1Answer = New System.Windows.Forms.Label()
        Me.lblQ2Answer = New System.Windows.Forms.Label()
        Me.lblQ3Answer = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Location = New System.Drawing.Point(163, 46)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(156, 13)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Welcome to the bridge of death"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "What is your name?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "What is your quest?"
        '
        'txtNameGuess
        '
        Me.txtNameGuess.Location = New System.Drawing.Point(341, 126)
        Me.txtNameGuess.Name = "txtNameGuess"
        Me.txtNameGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtNameGuess.TabIndex = 4
        '
        'txtQuestGuess
        '
        Me.txtQuestGuess.Location = New System.Drawing.Point(341, 194)
        Me.txtQuestGuess.Name = "txtQuestGuess"
        Me.txtQuestGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtQuestGuess.TabIndex = 5
        '
        'txtColorGuess
        '
        Me.txtColorGuess.Location = New System.Drawing.Point(341, 267)
        Me.txtColorGuess.Name = "txtColorGuess"
        Me.txtColorGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtColorGuess.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "What is your favorite color?"
        '
        'lblQ1Answer
        '
        Me.lblQ1Answer.AutoSize = True
        Me.lblQ1Answer.Location = New System.Drawing.Point(83, 373)
        Me.lblQ1Answer.Name = "lblQ1Answer"
        Me.lblQ1Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ1Answer.TabIndex = 8
        '
        'lblQ2Answer
        '
        Me.lblQ2Answer.AutoSize = True
        Me.lblQ2Answer.Location = New System.Drawing.Point(217, 373)
        Me.lblQ2Answer.Name = "lblQ2Answer"
        Me.lblQ2Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ2Answer.TabIndex = 9
        '
        'lblQ3Answer
        '
        Me.lblQ3Answer.AutoSize = True
        Me.lblQ3Answer.Location = New System.Drawing.Point(338, 373)
        Me.lblQ3Answer.Name = "lblQ3Answer"
        Me.lblQ3Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ3Answer.TabIndex = 10
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(201, 312)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 427)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblQ3Answer)
        Me.Controls.Add(Me.lblQ2Answer)
        Me.Controls.Add(Me.lblQ1Answer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtColorGuess)
        Me.Controls.Add(Me.txtQuestGuess)
        Me.Controls.Add(Me.txtNameGuess)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNameGuess As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestGuess As System.Windows.Forms.TextBox
    Friend WithEvents txtColorGuess As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblQ1Answer As System.Windows.Forms.Label
    Friend WithEvents lblQ2Answer As System.Windows.Forms.Label
    Friend WithEvents lblQ3Answer As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button

End Class
