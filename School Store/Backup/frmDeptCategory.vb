Imports System.Data.SqlClient

Public Class frmDeptCategory
    Implements StoreInterface

    Dim modDept As String = "QUERY"
    Dim modCat As String = "QUERY"
    Dim autoNo As Integer
    Dim autoNo1 As Integer
    Private tp As New TabPage("Department and Category")
    Private pForm As frmMaster

    Private Sub frmDeptCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        frmMaster.ToggleControls(True)
        LoadSpreadDepartment()
        LoadDepartment()

    End Sub

    Private Sub GenerateDeptCode()
        Dim rs As New ADODB.Recordset
        sql = "select MAX(Pn_Dept_Code) as autoNo  from m_Dept"

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If IsDBNull(rs("autoNo").Value) Then
            'autoNo = rs("autoNo").Value
            autoNo = 1
        Else
            autoNo = rs("autoNo").Value + 1
        End If
        rs.Close()
    End Sub

    Private Sub GenerateCatNo()
        Dim rs As New ADODB.Recordset
        sql = "select MAX(pn_Category_No) as autoNo  from m_Category"

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If IsDBNull(rs("autoNo").Value) Then
            'autoNo = rs("autoNo").Value
            autoNo1 = 1
        Else
            autoNo1 = rs("autoNo").Value + 1
        End If
        rs.Close()
    End Sub

    Private Sub LoadDepartment()
        cmbDepartment.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Dept_Name from m_Dept"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cmbDepartment.Items.Add(rs("v_Dept_Name").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub ClearDept()
        txtDepartment.Text = ""
        rtDescription.Text = ""
    End Sub

    Private Sub ClearCat()
        txtCatName.Text = ""
        rtCatDesc.Text = ""
    End Sub

    Public Sub FormCancel() Implements StoreInterface.FormCancel
        If tabPageDepartment.Focus = True Then
            ClearDept()
            modDept = "QUERY"
        ElseIf tabPageCategory.Focus = True Then
            ClearCat()
            modCat = "QUERY"
        Else
            'ClearUser()
        End If

    End Sub

    Public Sub FormEdit() Implements StoreInterface.FormEdit
        mode = "EDIT"
        frmMaster.ToggleControls(False)
        If tabPageDepartment.Focus = True Then
            modDept = "UPDATE"
        ElseIf tabPageCategory.Focus = True Then
            modCat = "UPDATE"
        Else
            'do nothing
        End If
    End Sub

    Public Sub FormNew() Implements StoreInterface.FormNew
        mode = "NEW"
        ClearDept()
        ClearCat()
        frmMaster.ToggleControls(False)
        If tabPageDepartment.Focus = True Then
            modDept = "UPDATE"
        ElseIf tabPageCategory.Focus = True Then
            modCat = "UPDATE"
        Else
            'do nothing
        End If
    End Sub

    Public Sub FormSave() Implements StoreInterface.FormSave
        If tabPageDepartment.Focus = True Then
            If txtDepartment.Text = "" Then
                MsgBox("Please enter the role name", MsgBoxStyle.Information, "User and Role")
            ElseIf txtDepartment.Text = "" Then
                MsgBox("Please enter the approval limit", MsgBoxStyle.Information, "User and Role")
            Else
                SaveDept()
            End If
        ElseIf tabPageCategory.Focus = True Then
            If txtCatName.Text = "" Then
                MsgBox("Please enter the role name", MsgBoxStyle.Information, "User and Role")
            ElseIf txtCatName.Text = "" Then
                MsgBox("Please enter the approval limit", MsgBoxStyle.Information, "User and Role")
            Else
                SaveCat()
            End If

        Else
            'If txt.Text = "" Then
            '    MsgBox("Please enter the user name", MsgBoxStyle.Information, "User and Role")
            'ElseIf txtPassword.Text = "" Then
            '    MsgBox("Please enter the password", MsgBoxStyle.Information, "User and Role")
            'ElseIf cmbRole.Text = "" Then
            '    MsgBox("Please select a Role", MsgBoxStyle.Information, "User and Role")
            'Else
            '    SaveUsers()
            'End If
        End If
    End Sub

    Private Sub SaveDept()
        GenerateDeptCode()
       

        If mode = "NEW" Then
            sql = "select * from m_Dept where v_Dept_Name='" & txtDepartment.Text & "'"

            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            If Not rs.EOF Then
                conn.RollbackTrans()
                Me.Cursor = Cursors.Arrow
                MsgBox("Department name exist,please enter different name", MsgBoxStyle.Information, "Department and Category")
                rs.Close()
                Exit Sub
            Else
                rs.AddNew()
                rs("pn_Dept_Code").Value = autoNo
            End If
        ElseIf mode = "EDIT" Then
            sprDept.Row = sprDept.ActiveRow
            sprDept.Col = 2
            sql = "select * from m_Dept where pn_Dept_Code='" & sprDept.Text & "'"
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                conn.RollbackTrans()
                Me.Cursor = Cursors.Arrow
                MsgBox("Department name does not exist", MsgBoxStyle.Information, "Department and Category")
                rs.Close()
                Exit Sub
            End If
        End If

        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            rs("v_Dept_Name").Value = txtDepartment.Text
            rs("v_Description").Value = rtDescription.Text
            rs.Update()
            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Department and Category")
            ClearDept()
            rs.Close()
            LoadSpreadDepartment()
            frmMaster.ToggleControls(True)

            modDept = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")
        End Try

    End Sub


    Private Sub frmDeptCategory_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult
        If modDept = "UPDATE" Or modCat = "UPDATE" Then
            result = MessageBox.Show("Do you want to close the form without saving?", "Department and Category", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.OK Then
                modDept = "QUERY"
                modCat = "QUERY"
                frmMaster.ToggleControls(True)
            Else
                e.Cancel = True
                Exit Sub
            End If
        End If

        pForm.RemoveTabPage(tp)
    End Sub

    Private Sub frmDeptCategory_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If tabPageDepartment.Focus = True Then
            If modDept = "QUERY" Then
                frmMaster.ToggleControls(True)
            Else
                frmMaster.ToggleControls(False)
            End If
        ElseIf tabPageCategory.Focus = True Then
            If modCat = "QUERY" Then
                frmMaster.ToggleControls(True)
            Else
                frmMaster.ToggleControls(False)
            End If
        End If
    End Sub

    Private Sub LoadSpreadDepartment()
        sprDept.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from m_Dept"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                sprDept.MaxRows = sprDept.MaxRows + 1
                sprDept.Row = sprDept.MaxRows
                sprDept.Col = 1
                sprDept.TypeButtonText = "Edit"
                sprDept.Col = 1
                sprDept.Text = rs("v_Dept_Name").Value
                sprDept.Col = 2
                sprDept.Text = rs("pn_Dept_Code").Value
                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Private Sub sprDept_ClickEvent(ByVal sender As System.Object, ByVal e As AxFPSpread._DSpreadEvents_ClickEvent) Handles sprDept.ClickEvent
        sprDept.Row = sprDept.ActiveRow
        sprDept.Col = 2
        sql = "SELECT * FROM m_Dept where pn_Dept_Code= '" & sprDept.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtDepartment.Text = rs("v_Dept_Name").Value
            rtDescription.Text = rs("v_Description").Value
        Else
            MsgBox("No Department. Add new")
        End If
        rs.Close()

    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
        sql = "Select * from m_Dept where v_Dept_Name='" & cmbDepartment.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtDeptCode.Text = rs("pn_Dept_Code").Value
        End If
        rs.Close()
        LoadSpreadCategory()
    End Sub

    Private Sub sprCategory_ClickEvent(ByVal sender As System.Object, ByVal e As AxFPSpread._DSpreadEvents_ClickEvent) Handles sprCategory.ClickEvent
        sprCategory.Row = sprCategory.ActiveRow
        sprCategory.Col = 2
        sql = "SELECT * FROM m_Category where pn_Category_No= '" & sprCategory.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtCatName.Text = rs("v_Category_Name").Value
            rtCatDesc.Text = rs("v_Desc").Value
        Else
            MsgBox("No Category. Add new")
        End If
        rs.Close()
    End Sub

    Private Sub LoadSpreadCategory()
        sprCategory.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from m_Category Where fn_Dept_Code='" & txtDeptCode.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                sprCategory.MaxRows = sprCategory.MaxRows + 1
                sprCategory.Row = sprCategory.MaxRows
                sprCategory.Col = 1
                sprCategory.TypeButtonText = "Edit"
                sprCategory.Col = 1
                sprCategory.Text = rs("v_Category_Name").Value
                sprCategory.Col = 2
                sprCategory.Text = rs("pn_Category_No").Value
                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Private Sub SaveCat()
        GenerateCatNo()
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then
                sql = "select * from m_Category where v_Category_Name='" & txtCatName.Text & "'"

                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                If Not rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Category name exist,please enter different name", MsgBoxStyle.Information, "Department and Category")
                    rs.Close()
                    Exit Sub
                Else
                    rs.AddNew()
                    rs("pn_Category_No").Value = autoNo1
                End If
            ElseIf mode = "EDIT" Then
                sprCategory.Row = sprCategory.ActiveRow
                sprCategory.Col = 2
                sql = "select * from m_Category where pn_Category_No='" & sprCategory.Text & "'"
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Category name does not exist", MsgBoxStyle.Information, "Department and Category")
                    rs.Close()
                    Exit Sub
                End If
            End If

            rs("v_Category_Name").Value = txtCatName.Text
            rs("v_Desc").Value = rtCatDesc.Text
            rs("fn_Dept_Code").Value = txtDeptCode.Text

            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Department and Category")
            ClearCat()
            rs.Close()
            LoadSpreadCategory()
            frmMaster.ToggleControls(True)

            modCat = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")
        End Try

    End Sub

    Private Sub txtDeptCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeptCode.TextChanged

    End Sub

    Private Sub txtCatName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCatName.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Public Sub FormSubmit() Implements StoreInterface.FormSubmit

    End Sub

    Private Sub tabPageDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabPageDepartment.Click

    End Sub
End Class