Imports System.Data.SqlClient

Public Class frmReceiver
    Implements StoreInterface

    Dim modReceiver As String = "QUERY"
    Dim autoNo4 As Integer
    Private tp As New TabPage("Receiver")
    Private pForm As frmMaster

    Private Sub GenerateReceiverRefNo()
        Dim rs As New ADODB.Recordset
        sql = "select MAX(pn_Receiver_Id) as autoNo  from m_Receiver"

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If IsDBNull(rs("autoNo").Value) Then
            'autoNo = rs("autoNo").Value
            autoNo4 = 1000
        Else
            autoNo4 = rs("autoNo").Value + 1
        End If
        rs.Close()
    End Sub

    Private Sub ClearReceiver()
        txtID.Text = ""
        txtRecName.Text = ""
        txtPhone.Text = ""

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub AxvaSpread1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpread._DSpreadEvents_AdvanceEvent)

    End Sub

    Private Sub frmReceiver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        frmMaster.ToggleControls(True)
        LoadSpreadReceiver()
    End Sub

    Public Sub FormCancel() Implements StoreInterface.FormCancel
        ClearReceiver()
        frmMaster.ToggleControls(True)
    End Sub

    Public Sub FormEdit() Implements StoreInterface.FormEdit
        mode = "EDIT"
        frmMaster.ToggleControls(False)
    End Sub

    Public Sub FormNew() Implements StoreInterface.FormNew
        mode = "NEW"
        ClearReceiver()
        frmMaster.ToggleControls(False)
    End Sub

    Public Sub FormSave() Implements StoreInterface.FormSave
        SaveReceiver()
    End Sub

    Private Sub SaveReceiver()
        GenerateReceiverRefNo()

       
        If mode = "NEW" Then
            sql = "select * from m_Receiver where v_Receiver_Name='" & txtRecName.Text & "'"

            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            If Not rs.EOF Then
                'conn.RollbackTrans()
                'Me.Cursor = Cursors.Arrow
                MsgBox("Receiver name exist,please enter different name", MsgBoxStyle.Information, "Receiver")
                rs.Close()
                Exit Sub
            Else
                rs.AddNew()
                rs("pn_Receiver_Id").Value = autoNo4
            End If
        ElseIf mode = "EDIT" Then
            sprReceiver.Row = sprReceiver.ActiveRow
            sprReceiver.Col = 2
            sql = "select * from m_Receiver where pn_Receiver_Id='" & sprReceiver.Text & "'"
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                'conn.RollbackTrans()
                'Me.Cursor = Cursors.Arrow
                MsgBox("Receiver name does not exist", MsgBoxStyle.Information, "Receiver")
                rs.Close()
                Exit Sub
            End If
        End If
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            rs("v_Receiver_Name").Value = txtRecName.Text
            rs("v_Receiver_phone").Value = txtPhone.Text

            rs.Update()
            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Receiver")
            ClearReceiver()
            rs.Close()
            LoadSpreadReceiver()
            frmMaster.ToggleControls(True)

            modReceiver = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")
        End Try

    End Sub

    Private Sub frmSupplier_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult
        If modReceiver = "UPDATE" Then
            result = MessageBox.Show("Do you want to close the form without saving?", "modReceiver", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.OK Then
                modReceiver = "QUERY"
                frmMaster.ToggleControls(True)
            Else
                e.Cancel = True
                Exit Sub
            End If
        End If
        pForm.RemoveTabPage(tp)
    End Sub

    Private Sub sprSupplier_ClickEvent(ByVal sender As System.Object, ByVal e As AxFPSpread._DSpreadEvents_ClickEvent) Handles sprReceiver.ClickEvent
        sprReceiver.Row = sprReceiver.ActiveRow
        sprReceiver.Col = 1
        sql = "SELECT * FROM m_Receiver where pn_Receiver_Id= '" & sprReceiver.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtID.Text = rs("pn_Receiver_Id").Value
            txtRecName.Text = rs("v_Receiver_Name").Value
            txtPhone.Text = rs("v_Receiver_phone").Value

        Else
            MsgBox("No Receiver. Add new")
        End If
        rs.Close()
    End Sub

    Private Sub LoadSpreadReceiver()
        sprReceiver.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from m_Receiver"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                sprReceiver.MaxRows = sprReceiver.MaxRows + 1
                sprReceiver.Row = sprReceiver.MaxRows
                sprReceiver.Col = 1
                sprReceiver.TypeButtonText = "Edit"
                sprReceiver.Col = 1
                sprReceiver.Text = rs("pn_Receiver_Id").Value
                sprReceiver.Col = 2
                sprReceiver.Text = rs("v_Receiver_Name").Value
                sprReceiver.Col = 3
                sprReceiver.Text = rs("v_Receiver_phone").Value

                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Private Sub AxvaSpreadReceiver_ClickEvent(ByVal sender As System.Object, ByVal e As AxFPSpread._DSpreadEvents_ClickEvent) Handles sprReceiver.ClickEvent

    End Sub

    Public Sub FormSubmit() Implements StoreInterface.FormSubmit

    End Sub
End Class