﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblPrizeVal = New System.Windows.Forms.Label()
        Me.lblWinnings = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblForfeit = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.picPrize = New System.Windows.Forms.PictureBox()
        Me.timSpin = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPrize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(700, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Panther Prize Gallery - Spin to Win Prizes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(43, 110)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(160, 45)
        Me.lblResult.TabIndex = 1
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrizeVal
        '
        Me.lblPrizeVal.BackColor = System.Drawing.Color.White
        Me.lblPrizeVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrizeVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrizeVal.Location = New System.Drawing.Point(43, 196)
        Me.lblPrizeVal.Name = "lblPrizeVal"
        Me.lblPrizeVal.Size = New System.Drawing.Size(160, 45)
        Me.lblPrizeVal.TabIndex = 2
        Me.lblPrizeVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWinnings
        '
        Me.lblWinnings.BackColor = System.Drawing.Color.White
        Me.lblWinnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWinnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnings.Location = New System.Drawing.Point(43, 281)
        Me.lblWinnings.Name = "lblWinnings"
        Me.lblWinnings.Size = New System.Drawing.Size(160, 45)
        Me.lblWinnings.TabIndex = 3
        Me.lblWinnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Prize Value:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Your Total Winnings:"
        '
        'lblForfeit
        '
        Me.lblForfeit.AutoSize = True
        Me.lblForfeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForfeit.ForeColor = System.Drawing.Color.Red
        Me.lblForfeit.Location = New System.Drawing.Point(62, 338)
        Me.lblForfeit.Name = "lblForfeit"
        Me.lblForfeit.Size = New System.Drawing.Size(121, 29)
        Me.lblForfeit.TabIndex = 6
        Me.lblForfeit.Text = "You Lose!"
        Me.lblForfeit.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(43, 386)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(160, 48)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Start the Spin"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(43, 493)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(160, 47)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(43, 440)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(160, 47)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop the Spin"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'picPrize
        '
        Me.picPrize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPrize.Image = Global.PrizeGallery.My.Resources.Resources.prize_1
        Me.picPrize.Location = New System.Drawing.Point(229, 120)
        Me.picPrize.Name = "picPrize"
        Me.picPrize.Size = New System.Drawing.Size(174, 263)
        Me.picPrize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPrize.TabIndex = 0
        Me.picPrize.TabStop = False
        '
        'timSpin
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(785, 586)
        Me.Controls.Add(Me.picPrize)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblForfeit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblWinnings)
        Me.Controls.Add(Me.lblPrizeVal)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mystery Prizes"
        CType(Me.picPrize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblPrizeVal As Label
    Friend WithEvents lblWinnings As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblForfeit As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents picPrize As PictureBox
    Friend WithEvents timSpin As Timer
End Class
