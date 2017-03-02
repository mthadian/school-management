Public Class frmSchoolDetails
    Implements StoreInterface

    Private tp As New TabPage("School Details")

    Dim modSchoolDetails As String = "QUERY"
    'Dim autoNo8 As Integer

    Private pForm As frmMaster

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub btnBrowsePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsePic.Click
        Dim openfiledialog1 As New OpenFileDialog
        openfiledialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.jpeg"
        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicBoxSchoolBadge.Image = Image.FromFile(openfiledialog1.FileName)
        End If
    End Sub

    Private Sub LoadTitles()
        cbxPrincTitle.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "select v_title from t_titles"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxPrincTitle.Items.Add(rs("v_title").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub ClearSchoolDetails()

        txtaddress.Text = ""
        txtCity.Text = ""
        txtCountry.Text = ""
        txtEmail.Text = ""
        txtFax.Text = ""
        txtMotto.Text = ""
        txtNo1.Text = ""
        txtNo2.Text = ""
        txtPostalCode.Text = ""
        txtPrincipalName.Text = ""
        txtSchoolName.Text = ""
        txtTown.Text = ""
        txtWebsite.Text = ""
        txtSchoolCode.Text = ""
        cbxPrincTitle.Text = ""
        PicBoxSchoolBadge.Image = Nothing
    End Sub

    Private Sub cbxPrincTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxPrincTitle.SelectedIndexChanged
        'LoadTitles()
        'sql = "select * from t_titles where v_title='" & cbxPrincTitle.Text & "'"
        'rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

    End Sub

    Private Sub frmSchoolDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        frmMaster.ToggleControls(True)
        LoadTitles()
    End Sub

    Private Sub frmSchoolDetails_Formclosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
    End Sub

    Public Sub FormCancel() Implements StoreInterface.FormCancel
        ClearSchoolDetails()
        frmMaster.ToggleControls(True)
    End Sub

    Public Sub FormEdit() Implements StoreInterface.FormEdit
        mode = "EDIT"
        frmMaster.ToggleControls(False)
    End Sub

    Public Sub FormNew() Implements StoreInterface.FormNew
        mode = "NEW"
        ClearSchoolDetails()
        frmMaster.ToggleControls(False)
    End Sub

    Public Sub FormSave() Implements StoreInterface.FormSave
        SaveSchoolDetails()
        'ClearSchoolDetails()
    End Sub
    Private Sub SaveSchoolDetails()

        'conn.BeginTrans()
        'Me.Cursor = Cursors.WaitCursor
        'Try
        If mode = "NEW" Then
            sql = "select * from t_SchoolDetails where pn_SchoolCode='" & txtSchoolCode.Text & "'"

            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            If Not rs.EOF Then
                'conn.RollbackTrans()
                'Me.Cursor = Cursors.Arrow
                MsgBox("School name exist,please enter different name", MsgBoxStyle.Information, "School Details")
                rs.Close()
                Exit Sub
            Else
                rs.AddNew()
                rs("pn_SchoolCode").Value = txtSchoolCode.Text
                'rs("pn_Receiver_Id").Value = autoNo4
            End If
        ElseIf mode = "EDIT" Then

            sql = "select * from t_SchoolDetails where pn_SchoolCode='" & txtSchoolCode.Text & "'"
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                'conn.RollbackTrans()
                'Me.Cursor = Cursors.Arrow
                MsgBox("Item does not exist")
                rs.Close()
                Exit Sub
            End If
        End If
        rs("n_PhoneNo1").Value = txtNo1.Text
        rs("n_PhoneNo2").Value = txtNo2.Text
        rs("v_SchoolName").Value = txtSchoolName.Text
        rs("v_SchoolMotto").Value = txtMotto.Text
        rs("v_PrincipalName").Value = txtPrincipalName.Text

        rs("v_SchoolEmail").Value = txtEmail.Text
        rs("v_Website").Value = txtWebsite.Text
        rs("n_Fax").Value = txtFax.Text
        rs("v_SchoolAddress").Value = txtaddress.Text
        rs("n_PostalCode").Value = txtPostalCode.Text
        rs("v_Town").Value = txtTown.Text
        rs("v_City").Value = txtCity.Text
        rs("v_Country").Value = txtCountry.Text
        rs("im_SchoolBadge").Value = PicBoxSchoolBadge.Image
        rs("fv_Title").Value = cbxPrincTitle.Text

        rs.Update()

        'conn.CommitTrans()
        'Me.Cursor = Cursors.Arrow
        MsgBox("Saved successfully", MsgBoxStyle.Information, "School Details")
        ClearSchoolDetails()
        rs.Close()
        frmMaster.ToggleControls(True)

        modSchoolDetails = "QUERY"

        'Catch ex As Exception
        '    conn.RollbackTrans()
        '    Me.Cursor = Cursors.Arrow
        '    MsgBox(ex.Message, MsgBoxStyle.Information, "User")
        'End Try

    End Sub

    Public Sub FormSubmit() Implements StoreInterface.FormSubmit

    End Sub
End Class