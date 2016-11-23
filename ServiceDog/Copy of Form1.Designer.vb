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
        Me.components = New System.ComponentModel.Container()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCompName
        '
        Me.txtCompName.Location = New System.Drawing.Point(27, 32)
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.Size = New System.Drawing.Size(117, 20)
        Me.txtCompName.TabIndex = 0
        Me.txtCompName.Text = "MXL025032G-W7"
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
        Me.cmdStartService.Location = New System.Drawing.Point(280, 30)
        Me.cmdStartService.Name = "cmdStartService"
        Me.cmdStartService.Size = New System.Drawing.Size(105, 23)
        Me.cmdStartService.TabIndex = 2
        Me.cmdStartService.Text = "Start Workspace"
        Me.cmdStartService.UseVisualStyleBackColor = True
        '
        'cmdReadList
        '
        Me.cmdReadList.Location = New System.Drawing.Point(141, 90)
        Me.cmdReadList.Name = "cmdReadList"
        Me.cmdReadList.Size = New System.Drawing.Size(123, 29)
        Me.cmdReadList.TabIndex = 3
        Me.cmdReadList.Text = "Load PC List"
        Me.cmdReadList.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(403, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 4
        Me.txtName.Text = "cn\boylan.cj"
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
        Me.txtPass.Location = New System.Drawing.Point(406, 74)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
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
        Me.cmdCredSet.Location = New System.Drawing.Point(412, 108)
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
        Me.cmdMassStart.Location = New System.Drawing.Point(28, 175)
        Me.cmdMassStart.Name = "cmdMassStart"
        Me.cmdMassStart.Size = New System.Drawing.Size(130, 31)
        Me.cmdMassStart.TabIndex = 10
        Me.cmdMassStart.Text = "Start Group"
        Me.cmdMassStart.UseVisualStyleBackColor = True
        '
        'txtProcessed
        '
        Me.txtProcessed.Location = New System.Drawing.Point(228, 138)
        Me.txtProcessed.Name = "txtProcessed"
        Me.txtProcessed.Size = New System.Drawing.Size(46, 20)
        Me.txtProcessed.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Processed"
        '
        'Form1BindingSource
        '
        Me.Form1BindingSource.DataSource = GetType(ServiceDog.Form1)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 461)
        Me.Controls.Add(Me.Label3)
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
        Me.Text = "Form1"
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Form1BindingSource As System.Windows.Forms.BindingSource

End Class
