<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerScheduler
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
        Me.tableView = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_MainMenu = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Day = New System.Windows.Forms.Button()
        Me.btn_Week = New System.Windows.Forms.Button()
        Me.btn_Month = New System.Windows.Forms.Button()
        Me.btn_Year = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tableView
        '
        Me.tableView.AutoScroll = True
        Me.tableView.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.tableView.ColumnCount = 6
        Me.tableView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tableView.Location = New System.Drawing.Point(6, 101)
        Me.tableView.Name = "tableView"
        Me.tableView.RowCount = 11
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tableView.Size = New System.Drawing.Size(934, 498)
        Me.tableView.TabIndex = 0
        '
        'btn_MainMenu
        '
        Me.btn_MainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MainMenu.Location = New System.Drawing.Point(6, 53)
        Me.btn_MainMenu.Name = "btn_MainMenu"
        Me.btn_MainMenu.Size = New System.Drawing.Size(86, 34)
        Me.btn_MainMenu.TabIndex = 13
        Me.btn_MainMenu.Text = "Main Menu"
        Me.btn_MainMenu.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(740, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(623, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Schedule for week of:"
        '
        'btn_Day
        '
        Me.btn_Day.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Day.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Day.Location = New System.Drawing.Point(-1, -1)
        Me.btn_Day.Name = "btn_Day"
        Me.btn_Day.Size = New System.Drawing.Size(240, 34)
        Me.btn_Day.TabIndex = 23
        Me.btn_Day.Text = "Day"
        Me.btn_Day.UseVisualStyleBackColor = True
        '
        'btn_Week
        '
        Me.btn_Week.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_Week.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btn_Week.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Week.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Week.Location = New System.Drawing.Point(237, -1)
        Me.btn_Week.Name = "btn_Week"
        Me.btn_Week.Size = New System.Drawing.Size(240, 34)
        Me.btn_Week.TabIndex = 24
        Me.btn_Week.Text = "Week"
        Me.btn_Week.UseVisualStyleBackColor = False
        '
        'btn_Month
        '
        Me.btn_Month.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Month.Location = New System.Drawing.Point(475, -1)
        Me.btn_Month.Name = "btn_Month"
        Me.btn_Month.Size = New System.Drawing.Size(240, 34)
        Me.btn_Month.TabIndex = 25
        Me.btn_Month.Text = "Month"
        Me.btn_Month.UseVisualStyleBackColor = True
        '
        'btn_Year
        '
        Me.btn_Year.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Year.Location = New System.Drawing.Point(713, -1)
        Me.btn_Year.Name = "btn_Year"
        Me.btn_Year.Size = New System.Drawing.Size(240, 34)
        Me.btn_Year.TabIndex = 26
        Me.btn_Year.Text = "Year"
        Me.btn_Year.UseVisualStyleBackColor = True
        '
        'ManagerScheduler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 619)
        Me.Controls.Add(Me.btn_Year)
        Me.Controls.Add(Me.btn_Month)
        Me.Controls.Add(Me.btn_Week)
        Me.Controls.Add(Me.btn_Day)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btn_MainMenu)
        Me.Controls.Add(Me.tableView)
        Me.Name = "ManagerScheduler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pay Tread - Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tableView As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_MainMenu As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Day As System.Windows.Forms.Button
    Friend WithEvents btn_Week As System.Windows.Forms.Button
    Friend WithEvents btn_Month As System.Windows.Forms.Button
    Friend WithEvents btn_Year As System.Windows.Forms.Button
End Class
