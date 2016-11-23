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
        Me.txtCompName = New System.Windows.Forms.TextBox()
        Me.cmdServiceList = New System.Windows.Forms.Button()
        Me.cmdStartService = New System.Windows.Forms.Button()
        Me.cmdReadList = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCredSet = New System.Windows.Forms.Button()
        Me.cmdReport = New System.Windows.Forms.Button()
        Me.cmdMassStart = New System.Windows.Forms.Button()
        Me.txtProcessed = New System.Windows.Forms.TextBox()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.cmdClearFile = New System.Windows.Forms.Button()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.txtStarted = New System.Windows.Forms.TextBox()
        Me.lblRestarted = New System.Windows.Forms.Label()
        Me.txtRestarted = New System.Windows.Forms.TextBox()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.cmdAutoRun = New System.Windows.Forms.Button()
        Me.cmdIPtest = New System.Windows.Forms.Button()
        Me.cmdCheckA = New System.Windows.Forms.Button()
        Me.lblCheckA = New System.Windows.Forms.Label()
        Me.cmdSerial = New System.Windows.Forms.Button()
        Me.txtSerialProcessed = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCompName
        '
        Me.txtCompName.Location = New System.Drawing.Point(27, 32)
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.Size = New System.Drawing.Size(117, 20)
        Me.txtCompName.TabIndex = 0
        Me.txtCompName.Text = "L025032G-W7"
        '
        'cmdServiceList
        '
        Me.cmdServiceList.Location = New System.Drawing.Point(159, 28)
        Me.cmdServiceList.Name = "cmdServiceList"
        Me.cmdServiceList.Size = New System.Drawing.Size(105, 23)
        Me.cmdServiceList.TabIndex = 1
        Me.cmdServiceList.Text = "Check Services"
        Me.cmdServiceList.UseVisualStyleBackColor = True
        '
        'cmdStartService
        '
        Me.cmdStartService.Location = New System.Drawing.Point(280, 28)
        Me.cmdStartService.Name = "cmdStartService"
        Me.cmdStartService.Size = New System.Drawing.Size(105, 23)
        Me.cmdStartService.TabIndex = 2
        Me.cmdStartService.Text = "Start Workspace"
        Me.cmdStartService.UseVisualStyleBackColor = True
        '
        'cmdReadList
        '
        Me.cmdReadList.Location = New System.Drawing.Point(29, 87)
        Me.cmdReadList.Name = "cmdReadList"
        Me.cmdReadList.Size = New System.Drawing.Size(130, 29)
        Me.cmdReadList.TabIndex = 3
        Me.cmdReadList.Text = "Load PC List"
        Me.cmdReadList.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(403, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(114, 20)
        Me.txtName.TabIndex = 4
        Me.txtName.Text = "xx\xx"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "UserName  <domain\user>"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(403, 74)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.txtPass.Size = New System.Drawing.Size(114, 20)
        Me.txtPass.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(406, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'cmdCredSet
        '
        Me.cmdCredSet.Location = New System.Drawing.Point(406, 115)
        Me.cmdCredSet.Name = "cmdCredSet"
        Me.cmdCredSet.Size = New System.Drawing.Size(111, 24)
        Me.cmdCredSet.TabIndex = 8
        Me.cmdCredSet.Text = "Set Credentials"
        Me.cmdCredSet.UseVisualStyleBackColor = True
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(28, 133)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(131, 28)
        Me.cmdReport.TabIndex = 9
        Me.cmdReport.Text = "Report Service"
        Me.cmdReport.UseVisualStyleBackColor = True
        '
        'cmdMassStart
        '
        Me.cmdMassStart.Location = New System.Drawing.Point(29, 186)
        Me.cmdMassStart.Name = "cmdMassStart"
        Me.cmdMassStart.Size = New System.Drawing.Size(130, 31)
        Me.cmdMassStart.TabIndex = 10
        Me.cmdMassStart.Text = "Start Group"
        Me.cmdMassStart.UseVisualStyleBackColor = True
        Me.cmdMassStart.Visible = False
        '
        'txtProcessed
        '
        Me.txtProcessed.Location = New System.Drawing.Point(228, 138)
        Me.txtProcessed.Name = "txtProcessed"
        Me.txtProcessed.Size = New System.Drawing.Size(63, 20)
        Me.txtProcessed.TabIndex = 12
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.Location = New System.Drawing.Point(168, 139)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(57, 13)
        Me.lblReport.TabIndex = 13
        Me.lblReport.Text = "Processed"
        '
        'cmdClearFile
        '
        Me.cmdClearFile.Location = New System.Drawing.Point(406, 148)
        Me.cmdClearFile.Name = "cmdClearFile"
        Me.cmdClearFile.Size = New System.Drawing.Size(111, 30)
        Me.cmdClearFile.TabIndex = 14
        Me.cmdClearFile.Text = "Clear Result File"
        Me.cmdClearFile.UseVisualStyleBackColor = True
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(168, 195)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(57, 13)
        Me.lblStart.TabIndex = 15
        Me.lblStart.Text = "Processed"
        Me.lblStart.Visible = False
        '
        'txtStarted
        '
        Me.txtStarted.Location = New System.Drawing.Point(228, 191)
        Me.txtStarted.Name = "txtStarted"
        Me.txtStarted.Size = New System.Drawing.Size(63, 20)
        Me.txtStarted.TabIndex = 16
        Me.txtStarted.Visible = False
        '
        'lblRestarted
        '
        Me.lblRestarted.AutoSize = True
        Me.lblRestarted.Location = New System.Drawing.Point(168, 234)
        Me.lblRestarted.Name = "lblRestarted"
        Me.lblRestarted.Size = New System.Drawing.Size(55, 13)
        Me.lblRestarted.TabIndex = 17
        Me.lblRestarted.Text = "ReStarted"
        Me.lblRestarted.Visible = False
        '
        'txtRestarted
        '
        Me.txtRestarted.Location = New System.Drawing.Point(228, 227)
        Me.txtRestarted.Name = "txtRestarted"
        Me.txtRestarted.Size = New System.Drawing.Size(63, 20)
        Me.txtRestarted.TabIndex = 18
        Me.txtRestarted.Visible = False
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.Location = New System.Drawing.Point(184, 95)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(62, 13)
        Me.lblLoad.TabIndex = 19
        Me.lblLoad.Text = "List Loaded"
        Me.lblLoad.Visible = False
        '
        'cmdAutoRun
        '
        Me.cmdAutoRun.Location = New System.Drawing.Point(406, 184)
        Me.cmdAutoRun.Name = "cmdAutoRun"
        Me.cmdAutoRun.Size = New System.Drawing.Size(111, 27)
        Me.cmdAutoRun.TabIndex = 20
        Me.cmdAutoRun.Text = "Load and Start"
        Me.cmdAutoRun.UseVisualStyleBackColor = True
        '
        'cmdIPtest
        '
        Me.cmdIPtest.Location = New System.Drawing.Point(391, 270)
        Me.cmdIPtest.Name = "cmdIPtest"
        Me.cmdIPtest.Size = New System.Drawing.Size(75, 23)
        Me.cmdIPtest.TabIndex = 21
        Me.cmdIPtest.Text = "Ip test"
        Me.cmdIPtest.UseVisualStyleBackColor = True
        '
        'cmdCheckA
        '
        Me.cmdCheckA.Location = New System.Drawing.Point(29, 270)
        Me.cmdCheckA.Name = "cmdCheckA"
        Me.cmdCheckA.Size = New System.Drawing.Size(130, 35)
        Me.cmdCheckA.TabIndex = 22
        Me.cmdCheckA.Text = "Check AgentService"
        Me.cmdCheckA.UseVisualStyleBackColor = True
        '
        'lblCheckA
        '
        Me.lblCheckA.AutoSize = True
        Me.lblCheckA.Location = New System.Drawing.Point(168, 281)
        Me.lblCheckA.Name = "lblCheckA"
        Me.lblCheckA.Size = New System.Drawing.Size(57, 13)
        Me.lblCheckA.TabIndex = 23
        Me.lblCheckA.Text = "Processed"
        '
        'cmdSerial
        '
        Me.cmdSerial.Location = New System.Drawing.Point(391, 340)
        Me.cmdSerial.Name = "cmdSerial"
        Me.cmdSerial.Size = New System.Drawing.Size(75, 23)
        Me.cmdSerial.TabIndex = 24
        Me.cmdSerial.Text = "Serial # Grab"
        Me.cmdSerial.UseVisualStyleBackColor = True
        '
        'txtSerialProcessed
        '
        Me.txtSerialProcessed.Location = New System.Drawing.Point(485, 344)
        Me.txtSerialProcessed.Name = "txtSerialProcessed"
        Me.txtSerialProcessed.Size = New System.Drawing.Size(31, 20)
        Me.txtSerialProcessed.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 446)
        Me.Controls.Add(Me.txtSerialProcessed)
        Me.Controls.Add(Me.cmdSerial)
        Me.Controls.Add(Me.lblCheckA)
        Me.Controls.Add(Me.cmdCheckA)
        Me.Controls.Add(Me.cmdIPtest)
        Me.Controls.Add(Me.cmdAutoRun)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.txtRestarted)
        Me.Controls.Add(Me.lblRestarted)
        Me.Controls.Add(Me.txtStarted)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.cmdClearFile)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.txtProcessed)
        Me.Controls.Add(Me.cmdMassStart)
        Me.Controls.Add(Me.cmdReport)
        Me.Controls.Add(Me.cmdCredSet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmdReadList)
        Me.Controls.Add(Me.cmdStartService)
        Me.Controls.Add(Me.cmdServiceList)
        Me.Controls.Add(Me.txtCompName)
        Me.Name = "Form1"
        Me.Text = "Service Dog - Find PCs and start the Workspace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCompName As System.Windows.Forms.TextBox
    Friend WithEvents cmdServiceList As System.Windows.Forms.Button
    Friend WithEvents cmdStartService As System.Windows.Forms.Button
    Friend WithEvents cmdReadList As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdCredSet As System.Windows.Forms.Button
    Friend WithEvents cmdReport As System.Windows.Forms.Button
    Friend WithEvents cmdMassStart As System.Windows.Forms.Button
    Friend WithEvents txtProcessed As System.Windows.Forms.TextBox
    Friend WithEvents lblReport As System.Windows.Forms.Label
    Friend WithEvents cmdClearFile As System.Windows.Forms.Button
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents txtStarted As System.Windows.Forms.TextBox
    Friend WithEvents lblRestarted As System.Windows.Forms.Label
    Friend WithEvents txtRestarted As System.Windows.Forms.TextBox
    Friend WithEvents lblLoad As System.Windows.Forms.Label
    Friend WithEvents cmdAutoRun As System.Windows.Forms.Button
    Friend WithEvents cmdIPtest As System.Windows.Forms.Button
    Friend WithEvents cmdCheckA As System.Windows.Forms.Button
    Friend WithEvents lblCheckA As System.Windows.Forms.Label
    Friend WithEvents cmdSerial As System.Windows.Forms.Button
    Friend WithEvents txtSerialProcessed As System.Windows.Forms.TextBox

End Class
