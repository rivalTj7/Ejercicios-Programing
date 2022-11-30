<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreporteproducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreporteproducto))
        Me.mostrar_productoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbpersonalDataSet = New sispersonal.dbpersonalDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mostrar_productoTableAdapter = New sispersonal.dbpersonalDataSetTableAdapters.mostrar_productoTableAdapter()
        CType(Me.mostrar_productoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbpersonalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrar_productoBindingSource
        '
        Me.mostrar_productoBindingSource.DataMember = "mostrar_producto"
        Me.mostrar_productoBindingSource.DataSource = Me.dbpersonalDataSet
        '
        'dbpersonalDataSet
        '
        Me.dbpersonalDataSet.DataSetName = "dbpersonalDataSet"
        Me.dbpersonalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_productoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sispersonal.rptproductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(883, 534)
        Me.ReportViewer1.TabIndex = 0
        '
        'mostrar_productoTableAdapter
        '
        Me.mostrar_productoTableAdapter.ClearBeforeFill = True
        '
        'frmreporteproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 534)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmreporteproducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Productos"
        CType(Me.mostrar_productoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbpersonalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_productoBindingSource As BindingSource
    Friend WithEvents dbpersonalDataSet As dbpersonalDataSet
    Friend WithEvents mostrar_productoTableAdapter As dbpersonalDataSetTableAdapters.mostrar_productoTableAdapter
End Class
