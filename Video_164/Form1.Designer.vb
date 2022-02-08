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
        Me.components = New System.ComponentModel.Container()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.btnAnimate = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(12, 261)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(190, 23)
        Me.btnDraw.TabIndex = 0
        Me.btnDraw.Text = "Draw Rectangle"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'btnAnimate
        '
        Me.btnAnimate.Location = New System.Drawing.Point(208, 261)
        Me.btnAnimate.Name = "btnAnimate"
        Me.btnAnimate.Size = New System.Drawing.Size(190, 23)
        Me.btnAnimate.TabIndex = 1
        Me.btnAnimate.Text = "Animate Rectangle"
        Me.btnAnimate.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 296)
        Me.Controls.Add(Me.btnAnimate)
        Me.Controls.Add(Me.btnDraw)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDraw As Button
    Friend WithEvents btnAnimate As Button
    Friend WithEvents Timer1 As Timer
End Class
