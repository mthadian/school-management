Imports System.Data.SqlClient

Public Class frmItems
    Implements StoreInterface

    Dim modItem As String = "QUERY"
    Dim autoNo3 As Integer
    Private tp As New TabPage("Items")
    Private pForm As frmMaster

    Private Sub frmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        LoadSpreadItem()
        LoadDepartment()
    End Sub

    Private Sub GenerateItemNo()
        Dim rs As New ADODB.Recordset
        sql = "select MAX(pn_Item_No) as autoNo  from m_Item"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If IsDBNull(rs("autoNo").Value) Then
            'autoNo = rs("autoNo").Value
            autoNo3 = 1
        Else
            autoNo3 = rs("autoNo").Value + 1
        End If
        rs.Close()
    End Sub

    Private Sub LoadDepartment()
        cmbItdept.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Dept_Name from m_Dept"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cmbItdept.Items.Add(rs("v_Dept_Name").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub LoadCategory()
        cmbItCat.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Category_Name from m_Category where fn_Dept_Code='" & txtDeptCode.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cmbItCat.Items.Add(rs("v_Category_Name").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub ClearItem()
        txtItemName.Text = ""
        rtItemDesc.Text = ""
        txtItemmsr.Text = ""
    End Sub

    Public Sub FormCancel() Implements StoreInterface.FormCancel
        ClearItem()
        frmMaster.ToggleControls(True)
    End Sub

    Public Sub FormEdit() Implements StoreInterface.FormEdit
        mode = "EDIT"
        frmMaster.ToggleControls(False)
    End Sub

    Public Sub FormNew() Implements StoreInterface.FormNew
        mode = "NEW"
        ClearItem()
        frmMaster.ToggleControls(False)
    End Sub

    Public Sub FormSave() Implements StoreInterface.FormSave
        SaveItem()
    End Sub

    Private Sub SaveItem()
        GenerateItemNo()
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then
                sql = "select * from m_Item where v_Item_Name='" & txtItemName.Text & "'"

                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                If Not rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Item name exist,please enter different name", MsgBoxStyle.Information, "Item")
                    rs.Close()
                    Exit Sub
                Else
                    rs.AddNew()
                    rs("pn_Item_No").Value = autoNo3
                End If
            ElseIf mode = "EDIT" Then
                sprItemm.Row = sprItemm.ActiveRow
                sprItemm.Col = 2
                sql = "select * from m_Item where pn_Item_No='" & sprItemm.Text & "'"
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Item name does not exist", MsgBoxStyle.Information, "Item")
                    rs.Close()
                    Exit Sub
                End If
            End If

            rs("v_Item_Name").Value = txtItemName.Text
            rs("v_Item_Description").Value = rtItemDesc.Text
            rs("v_Item_Measurement").Value = txtItemmsr.Text
            rs("fn_Dept_Code").Value = txtDeptCode.Text
            rs("fn_Category_No").Value = txtCatNo.Text

            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Item")
            ClearItem()
            rs.Close()
            LoadSpreadItem()
            frmMaster.ToggleControls(True)

            modItem = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

    End Sub

    Private Sub LoadSpreadItem()
        sprItemm.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from m_Item where fn_Dept_Code='" & txtDeptCode.Text & "' " & _
             "AND fn_Category_No='" & txtCatNo.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                sprItemm.MaxRows = sprItemm.MaxRows + 1
                sprItemm.Row = sprItemm.MaxRows
                sprItemm.Col = 1
                sprItemm.TypeButtonText = "Edit"
                sprItemm.Col = 1
                sprItemm.Text = rs("v_Item_Name").Value
                sprItemm.Col = 2
                sprItemm.Text = rs("pn_Item_No").Value
                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Private Sub sprItemm_ClickEvent(ByVal sender As System.Object, ByVal e As AxFPSpread._DSpreadEvents_ClickEvent) Handles sprItemm.ClickEvent
        Dim rs1 As New ADODB.Recordset
        sprItemm.Row = sprItemm.ActiveRow
        sprItemm.Col = 2
        sql = "SELECT * FROM m_Item where pn_Item_No= '" & sprItemm.Text & "'"
        Try
            rs1.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs1.EOF Then
            txtItemName.Text = rs1("v_Item_Name").Value
            rtItemDesc.Text = rs1("v_Item_Description").Value
            txtItemmsr.Text = rs1("v_Item_Measurement").Value
        Else
            MsgBox("No Item. Add new")
        End If
        rs1.Close()
    End Sub

    Private Sub cmbItdept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItdept.SelectedIndexChanged

        sql = "Select * from m_Dept where v_Dept_Name='" & cmbItdept.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtDeptCode.Text = rs("pn_Dept_Code").Value
        End If
        rs.Close()

        LoadCategory()
    End Sub

    Private Sub cmbItCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItCat.SelectedIndexChanged
        sql = "Select * from m_Category where v_Category_Name='" & cmbItCat.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtCatNo.Text = rs("pn_Category_No").Value
        End If
        rs.Close()

        LoadSpreadItem()
    End Sub

    Private Sub txtDeptCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeptCode.TextChanged

    End Sub

    Private Sub frmItem_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult
        If modItem = "UPDATE" Then
            result = MessageBox.Show("Do you want to close the form without saving?", "Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.OK Then
                modItem = "QUERY"
                frmMaster.ToggleControls(True)
            Else
                e.Cancel = True
                Exit Sub
            End If
        End If

        pForm.RemoveTabPage(tp)
    End Sub

    Private Sub frmDeptCategory_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If modItem = "QUERY" Then
            frmMaster.ToggleControls(True)
        Else
            frmMaster.ToggleControls(False)
        End If
        ' frmMaster.ToggleControls(False)

    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Public Sub FormSubmit() Implements StoreInterface.FormSubmit

    End Sub
End Class