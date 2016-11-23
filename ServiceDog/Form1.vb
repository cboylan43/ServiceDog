Imports System.IO

Public Class Form1
    Public strName As String
    Public strPass As String
    Public arlist As New ArrayList
    Public arresults As New ArrayList
    Public art(4, 2) As String
    

    Private Sub cmdServiceList_Click() Handles cmdServiceList.Click
        Dim strtemp
        Dim objWMIService, objService, strServiceList
        Dim colListOfServices
        Dim objLocator

        'finds selected item
        strtemp = txtCompName.Text
        strServiceList = strtemp + " ----Services: "
        If (strName = "") Then
            strName = InputBox("Enter name as follows domain\intranet name ", "Login Name", "xx\xx.xx")
            strPass = InputBox("Enter intranet password ", "Password")
        End If
        'connect to WMI on server listed in strtemp
        objLocator = CreateObject("WbemScripting.SwbemLocator")
        objWMIService = objLocator.ConnectServer(strtemp, "root\cimv2", strName, strPass)

        colListOfServices = objWMIService.ExecQuery("Select * from Win32_Service ")
        'Determine critiea for listing
        For Each objService In colListOfServices
            If (objService.name.ToString.StartsWith("w")) Then
                strServiceList = strServiceList + ":" + objService.name.ToString + ":" + objService.state.ToString + vbCrLf
            End If

        Next

        MsgBox(strServiceList)
    End Sub
    Private Sub cmdStartService_Click(sender As System.Object, e As System.EventArgs) Handles cmdStartService.Click
        Dim strtemp
        Dim sReturn

        'get Server name for WMI connection
        strtemp = txtCompName.Text

        If (strName = "") Then
            strName = InputBox("Enter name as follows domain\intranet name ", "Login Name", "xx\xx.xx")
            strPass = InputBox("Enter intranet password ", "Password")
        End If
        'connect to WMI on server listed in strtemp
        'objLocator = CreateObject("WbemScripting.SwbemLocator")
        'objWMIService = objLocator.ConnectServer(strtemp, "root\cimv2", strName, strPass)
        ''set object for stop of service
        'strtemp = "Win32_Service.Name='" & "workspace" & "'"
        'objServiceStop = objWMIService.Get(strtemp)
        'intReturn = objServiceStop.StartService()
        sReturn = StartService(strtemp, strName, strPass)
        MsgBox(sReturn)

    End Sub
    Private Function StartService(strPC As String, strName As String, strPass As String)
        Dim strtemp As String
        Dim objLocator, objWMIService
        Dim objServiceStop, intReturn
        Dim sreturn

        Try
            objLocator = CreateObject("WbemScripting.SwbemLocator")
            objWMIService = objLocator.ConnectServer(strPC, "root\cimv2", strName, strPass)
            'set object for stop of service
            strtemp = "Win32_Service.Name='" & "workspace" & "'"
            objServiceStop = objWMIService.Get(strtemp)
            intReturn = objServiceStop.StartService()
            Select Case intReturn
                Case 0
                    sreturn = "Success"
                Case 1
                    sreturn = "Not Supported"
                Case 2
                    sreturn = "Access Denied"
                Case 4
                    sreturn = "Invalid Service Control"
                Case 5
                    sreturn = "Service Cannot Accept Control"
                Case 6
                    sreturn = "Service Not Active"
                Case 8
                    sreturn = "Unknown Failure"
                Case 10
                    sreturn = "Service Already Running"
                Case 14
                    sreturn = "Service Disabled"
                Case 15
                    sreturn = "Service Logon Failure"
                Case 24
                    sreturn = "Service Already Paused"
                Case Else
                    sreturn = "Unknown Error on Destination PC"

            End Select


        Catch ex As Exception
            sreturn = "Unknown Exception"
        End Try

        Return (sreturn)

    End Function

    Private Sub cmdReadlist_Click(sender As System.Object, e As System.EventArgs) Handles cmdReadList.Click
        Readlist()

    End Sub
    Private Sub cmdCredSet_Click() Handles cmdCredSet.Click
        ' pulls data from text boxes so you don't have to keep entering it in
        strName = txtName.Text
        strPass = txtPass.Text


    End Sub
    Private Sub cmdreport_Click() Handles cmdReport.Click
        ' read the list of PCs and report their status
        Dim strtemp = ""
        Dim objWMIService, objService
        Dim strServiceList As String = ""
        Dim colListOfServices
        Dim objLocator
        Dim inttmp As Integer = 0
        objLocator = CreateObject("WbemScripting.SwbemLocator")
        lblReport.Text = "Processed"
        txtProcessed.Text = inttmp
        arresults.Clear()
        ReDim art(arlist.Count, 2)
        Do While inttmp < arlist.Count
            strtemp = arlist(inttmp).ToString
            Try
                objWMIService = objLocator.ConnectServer(strtemp, "root\cimv2", strName, strPass)
                colListOfServices = objWMIService.ExecQuery("Select * from Win32_Service ")
                'Determine critiea for listing
                For Each objService In colListOfServices
                    If (objService.name.ToString.Equals("workspace")) Then
                        'strServiceList = strServiceList + ":" + objService.name.ToString + ":" + objService.state.ToString + vbCrLf
                        arresults.Add(strtemp & "," & objService.name.ToString & "," & objService.state.ToString)
                        art.SetValue(strtemp, inttmp, 0)
                        art.SetValue(objService.name.ToString, inttmp, 1)
                        art.SetValue(objService.state.ToString, inttmp, 2)
                    End If

                Next
            Catch ex As Exception
                'strServiceList = strServiceList + ":" + arlist(inttmp).ToString + ": not able to connect" + vbCrLf
                arresults.Add(strtemp & ",Not Found,Unknown")
                art.SetValue(strtemp, inttmp, 0)
                art.SetValue("Not Found", inttmp, 1)
                art.SetValue("Unknown", inttmp, 2)
            End Try
            ExportResults(arresults(inttmp).ToString)
            inttmp = inttmp + 1
            txtProcessed.Text = inttmp

        Loop
        'MsgBox(strServiceList)
        'inttmp = 0
        'Do While inttmp < arresults.Count
        '    MsgBox(arresults(inttmp).ToString)
        '    MsgBox(art(inttmp, 0).ToString & art(inttmp, 1).ToString & art(inttmp, 2).ToString)
        '    inttmp = inttmp + 1
        'Loop
        lblReport.Text = "Finished"
        cmdMassStart.Visible = True

    End Sub
    Private Sub cmdMassStart_click() Handles cmdMassStart.Click
        ' run through list and try to start workspace on PC with workspace stopped
        Dim intCount As Integer = 0
        Dim intFix As Integer = 0
        Dim strtemp As String = ""
        Dim sReturn

        lblStart.Visible = True
        lblStart.Text = "Processed"
        lblRestarted.Visible = True
        lblRestarted.Text = "PCs Fixed"
        txtRestarted.Visible = True
        txtStarted.Visible = True
        txtStarted.Text = "0"
        Do While intCount < arresults.Count
            If art(intCount, 2).ToString = "Stopped" Then
                sReturn = StartService(art(intCount, 0).ToString, strName, strPass)
                'MsgBox(sReturn)
                ExportResults(art(intCount, 0).ToString & ",returned state," & sReturn)
                intFix = intFix + 1
                txtRestarted.Text = intFix
            End If
            txtStarted.Text = intCount
            intCount = intCount + 1
        Loop
        txtStarted.Text = intCount
        cmdMassStart.Visible = False
        lblStart.Text = "Completed"
        txtRestarted.Text = intFix


    End Sub

    Private Shared Sub ExportResults(strData As String)
        ' export results to test file in the location that the data was pulled from
        Dim strPath As String       ' This is the path of teh running application

        strPath = Application.StartupPath
        strPath = strPath & "\PCListExport.txt"
        If File.Exists(strPath) Then
            Dim sr As StreamWriter = File.AppendText(strPath)
            sr.WriteLine(strData)

            sr.Close()

        Else
            MsgBox("File with PC list does not exist, please make sure list is in same dir as exe and is called PCListExport.txt")
        End If
        'MsgBox(" Exported data " & strData)
    End Sub
    Private Sub cmdClearFile_click(sender As Object, e As System.EventArgs) Handles cmdClearFile.Click
        ' remove data from results file
        Dim strPath As String       ' This is the path of teh running application

        strPath = Application.StartupPath
        strPath = strPath & "\PCListExport.txt"
        If File.Exists(strPath) Then
            Dim sr As FileStream = File.Open(strPath, FileMode.Truncate)
            sr.Close()

        Else
            MsgBox("File with PC list does not exist, please make sure list is in same dir as exe and is called PCListExport.txt")
        End If
    End Sub

    Private Sub cmdAutoRun_click() Handles cmdAutoRun.Click
        ' this will load the list, check status and then try to start the service 
        Readlist()
        cmdreport_Click()
        cmdMassStart_click()
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Readlist()
        Dim strSrvlist As String    ' this is the file with the PCs listed
        Dim strPath As String       ' This is the path of teh running application
        Dim inttemp As Int16 = 0

        Dim strtemp As String
        strPath = Application.StartupPath
        strSrvlist = strPath & "\PCList.SRV"
        'MsgBox(strSrvlist)
        'Sets up listing of servers from text file
        'need to add total count box and completion notice
        arlist.Clear()
        arresults.Clear()

        If File.Exists(strSrvlist) Then
            Dim sr As StreamReader = File.OpenText(strSrvlist)

            Do While sr.Peek() > 0
                strtemp = sr.ReadLine()
                'MsgBox(strtemp & " = " & inttemp)
                arlist.Add(strtemp)
                'MsgBox(arlist(inttemp))
                inttemp = inttemp + 1

            Loop
            sr.Close()
            ExportResults("*** New Data Loaded ***," & Date.Today.Date.ToString)
        Else
            MsgBox("File with PC list does not exist, please make sure list is in same dir as exe and is called PCList.SRV")
        End If
        'MsgBox(inttemp.ToString & " PCs have been loaded")
        lblLoad.Visible = True
        lblLoad.Text = inttemp.ToString & " PCs have been loaded"
    End Sub

    Private Sub cmdiptest_click() Handles cmdIPtest.Click
        Dim intCount As Integer = 0
        Dim intFix As Integer = 0
        Dim strtemp As String = ""


        
        Do While intCount < arresults.Count
            testIPaddress(art(intCount, 0).ToString, strName, strPass)
            
            intCount = intCount + 1
        Loop
    End Sub

    Private Function testIPaddress(strPC As String, strName As String, strPass As String)
        Dim strtemp As String
        Dim objLocator, objWMIService
        Dim objIPconfigset
        Dim sreturn

        sreturn = "PC = " & strPC & vbCrLf

        Try
            objLocator = CreateObject("WbemScripting.SwbemLocator")
            objWMIService = objLocator.ConnectServer(strPC, "root\cimv2", strName, strPass)
            'set object for stop of service
            strtemp = ("Select IPAddress from Win32_NetworkAdapterConfiguration WHERE IPEnabled = True ")
            objIPconfigset = objWMIService.ExecQuery(strtemp)
            For Each IPConfig In objIPconfigset
                If IPConfig.IPAddress.ToString <> "" Then
                    For i = LBound(IPConfig.IPAddress) _
                        To UBound(IPConfig.IPAddress)
                        sreturn = (IPConfig.IPAddress(i)) + vbCrLf + sreturn

                    Next
                End If
            Next

        Catch ex As Exception
            sreturn = ex.Message.ToString
        End Try
        ExportResults("IPaddress=," + strPC + "," + sreturn)

        ' MsgBox(sreturn)

    End Function

    Private Sub cmdCheckA_Click() Handles cmdCheckA.Click
        ' read the list of PCs and report their status
        Dim strtemp = ""
        Dim objWMIService, objService
        Dim strServiceList As String = ""
        Dim colListOfServices
        Dim objLocator
        Dim inttmp As Integer = 0
        objLocator = CreateObject("WbemScripting.SwbemLocator")
        lblReport.Text = "Processed"
        txtProcessed.Text = inttmp
        arresults.Clear()
        ReDim art(arlist.Count, 2)
        Do While inttmp < arlist.Count
            strtemp = arlist(inttmp).ToString
            Try
                objWMIService = objLocator.ConnectServer(strtemp, "root\cimv2", strName, strPass)
                colListOfServices = objWMIService.ExecQuery("Select * from Win32_Service ")
                'Determine critiea for listing
                For Each objService In colListOfServices
                    If (objService.name.ToString.Equals("AgentService")) Then
                        'strServiceList = strServiceList + ":" + objService.name.ToString + ":" + objService.state.ToString + vbCrLf
                        arresults.Add(strtemp & "," & objService.name.ToString & "," & objService.state.ToString)
                        art.SetValue(strtemp, inttmp, 0)
                        art.SetValue(objService.name.ToString, inttmp, 1)
                        art.SetValue(objService.state.ToString, inttmp, 2)
                    End If

                Next
            Catch ex As Exception
                'strServiceList = strServiceList + ":" + arlist(inttmp).ToString + ": not able to connect" + vbCrLf
                arresults.Add(strtemp & ",Not Found,Unknown")
                art.SetValue(strtemp, inttmp, 0)
                art.SetValue("Not Found", inttmp, 1)
                art.SetValue("Unknown", inttmp, 2)
            End Try
            ExportResults(arresults(inttmp).ToString)
            inttmp = inttmp + 1
            txtProcessed.Text = inttmp

        Loop
        'MsgBox(strServiceList)
        'inttmp = 0
        'Do While inttmp < arresults.Count
        '    MsgBox(arresults(inttmp).ToString)
        '    MsgBox(art(inttmp, 0).ToString & art(inttmp, 1).ToString & art(inttmp, 2).ToString)
        '    inttmp = inttmp + 1
        'Loop
        lblCheckA.Text = "Finished"


    End Sub

    
    Private Sub cmdSerial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSerial.Click
        Dim intCount As Integer = 0
        Dim intFix As Integer = 0
        Dim strtemp As String = ""
        ExportResults(vbCrLf + "++ Serial Number check ++" + vbCrLf)
        Do While intCount < arresults.Count
            SerialFind(art(intCount, 0).ToString, strName, strPass)

            intCount = intCount + 1
            txtSerialProcessed.Text = intCount
        Loop
    End Sub
    Private Function SerialFind(ByVal strPC As String, ByVal strName As String, ByVal strPass As String)
        Dim strtemp As String
        Dim objLocator, objWMIService
        Dim objIPconfigset
        Dim sreturn
        Dim stroutput

        sreturn = "PC = " & strPC & vbCrLf

        Try
            objLocator = CreateObject("WbemScripting.SwbemLocator")
            objWMIService = objLocator.ConnectServer(strPC, "root\cimv2", strName, strPass)
            'set object for stop of service
            strtemp = ("Select * from Win32_BIOS")
            objIPconfigset = objWMIService.ExecQuery(strtemp)
            For Each objBIOS In objIPconfigset
                strOutput = "Serial Number : " & objBIOS.SerialNumber & vbCrLf
                strOutput = strOutput & "BIOS Version : " & objBIOS.Version & vbCrLf
                strOutput = strOutput & "Manufacturer : " & objBIOS.Manufacturer & vbCrLf
                'strOutput = strOutput & "BIOS Version : " & objBIOS.BIOSVersion & vbcrlf  -- many string available
                strOutput = strOutput & "Name : " & objBIOS.Name & vbCrLf
                strOutput = strOutput & "Description : " & objBIOS.Description & vbCrLf

                ' MsgBox(stroutput)
                sreturn = stroutput

            Next
            testIPaddress(strPC, strName, strPass)


        Catch ex As Exception
            sreturn = ex.Message.ToString


        End Try
        sreturn = strPC + "," + sreturn
        ExportResults(sreturn)
        ' MsgBox(sreturn)

    End Function
End Class
