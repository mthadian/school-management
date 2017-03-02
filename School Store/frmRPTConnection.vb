Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Configuration
Imports System.Data.OleDb

Public Class frmRPTConnection
    Private crtableLogoninfos As New TableLogOnInfos()
    Private crtableLogoninfo As New TableLogOnInfo()
    Private crConnectioninfo As New ConnectionInfo
    Private CrTables As Tables
    Private CrTable As Table

    Public Sub newRPTConnection(ByRef cry As ReportDocument)
        Try
            Dim sCnn As OleDbConnection = New OleDbConnection(My.Settings.StoreSetting)
            With crConnectioninfo
                .ServerName = sCnn.DataSource
                .DatabaseName = sCnn.Database
                .UserID = "sa"
                .Password = "admin"
                '.IntegratedSecurity = False
            End With

            CrTables = cry.Database.Tables

            For Each Me.CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectioninfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

       
        'For local

        'Dim sCnn As OleDbConnection = New OleDbConnection(My.Settings.school3ConnectionString)
        'With crConnectioninfo
        '    .ServerName = sCnn.DataSource
        '    .DatabaseName = sCnn.Database
        '    .UserID = "sa"
        '    .Password = "admin"
        '    '.IntegratedSecurity = True
        'End With

        'CrTables = cry.Database.Tables

        'For Each Me.CrTable In CrTables
        '    crtableLogoninfo = CrTable.LogOnInfo
        '    crtableLogoninfo.ConnectionInfo = crConnectioninfo
        '    CrTable.ApplyLogOnInfo(crtableLogoninfo)
        'Next

    End Sub

    'For testing

    'Public Sub newRPTConnection(ByRef cry As ReportDocument)
    '    Dim sCnn As OleDbConnection = New OleDbConnection(My.Settings.school3ConnectionString)
    '    With crConnectioninfo
    '        .ServerName = sCnn.DataSource
    '        .DatabaseName = sCnn.Database
    '        '.UserID = "sa"
    '        '.Password = "admin"
    '        .IntegratedSecurity = True
    '    End With

    '    CrTables = cry.Database.Tables

    '    For Each Me.CrTable In CrTables
    '        crtableLogoninfo = CrTable.LogOnInfo
    '        crtableLogoninfo.ConnectionInfo = crConnectioninfo
    '        CrTable.ApplyLogOnInfo(crtableLogoninfo)
    '    Next


    'End Sub


End Class
