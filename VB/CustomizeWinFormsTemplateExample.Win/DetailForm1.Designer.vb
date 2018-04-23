Partial Class DetailForm1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
            Me.barManager = Nothing
            Me.barDockControlBottom = Nothing
            Me.barDockControlLeft = Nothing
            Me.barDockControlRight = Nothing
            Me.barDockControlTop = Nothing
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailForm1))
        Me.barManager = New DevExpress.ExpressApp.Win.Templates.Bars.XafBarManagerV2(Me.components)
        Me.actionContainerObjectsCreation = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerObjectsCreation = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerFile = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerFile = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerClose = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerClose = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerSave = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerSave = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerExport = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerExport = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerPrint = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerPrint = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerUndoRedo = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerUndoRedo = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerEdit = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerEdit = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerRecordEdit = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerRecordEdit = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerWorkflow = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerWorkflow = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerOpenObject = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerOpenObject = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerRecordsNavigation = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerRecordsNavigation = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerView = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerView = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerReports = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerReports = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerSearch = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerSearch = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerFullTextSearch = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerFullTextSearch = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerFilters = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerFilters = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerTools = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerTools = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerOptions = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerOptions = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerDiagnostic = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerDiagnostic = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerAbout = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerAbout = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.actionContainerMenu = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerMenu = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me._mainMenuBar = New DevExpress.XtraBars.Bar()
        Me.barSubItemFile = New DevExpress.XtraBars.BarSubItem()
        Me.barSubItemEdit = New DevExpress.XtraBars.BarSubItem()
        Me.barSubItemView = New DevExpress.XtraBars.BarSubItem()
        Me.barSubItemTools = New DevExpress.XtraBars.BarSubItem()
        Me.barSubItemHelp = New DevExpress.XtraBars.BarSubItem()
        Me.standardToolBar = New DevExpress.XtraBars.Bar()
        Me._statusBar = New DevExpress.XtraBars.Bar()
        Me.barContainerStatusMessages = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.modelSynchronizationManager = New DevExpress.ExpressApp.Win.Templates.ModelSynchronizationManager(Me.components)
        Me.formStateModelSynchronizer = New DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer(Me.components)
        Me.viewSiteManager = New DevExpress.ExpressApp.Win.Templates.ViewSiteManager(Me.components)
        Me.viewSitePanel = New DevExpress.XtraEditors.PanelControl()
        Me.templateContextMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarLinkContainerExItem1 = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.BarLinkActionControlContainer1 = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerObjectsCreation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerUndoRedo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerRecordEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerWorkflow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerOpenObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerRecordsNavigation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerFullTextSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerTools, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerDiagnostic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.actionContainerMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.templateContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLinkActionControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barManager
        '
        Me.barManager.ActionContainers.Add(Me.actionContainerObjectsCreation)
        Me.barManager.ActionContainers.Add(Me.actionContainerFile)
        Me.barManager.ActionContainers.Add(Me.actionContainerClose)
        Me.barManager.ActionContainers.Add(Me.actionContainerSave)
        Me.barManager.ActionContainers.Add(Me.actionContainerExport)
        Me.barManager.ActionContainers.Add(Me.actionContainerPrint)
        Me.barManager.ActionContainers.Add(Me.actionContainerUndoRedo)
        Me.barManager.ActionContainers.Add(Me.actionContainerEdit)
        Me.barManager.ActionContainers.Add(Me.actionContainerRecordEdit)
        Me.barManager.ActionContainers.Add(Me.actionContainerWorkflow)
        Me.barManager.ActionContainers.Add(Me.actionContainerOpenObject)
        Me.barManager.ActionContainers.Add(Me.actionContainerRecordsNavigation)
        Me.barManager.ActionContainers.Add(Me.actionContainerView)
        Me.barManager.ActionContainers.Add(Me.actionContainerReports)
        Me.barManager.ActionContainers.Add(Me.actionContainerSearch)
        Me.barManager.ActionContainers.Add(Me.actionContainerFullTextSearch)
        Me.barManager.ActionContainers.Add(Me.actionContainerFilters)
        Me.barManager.ActionContainers.Add(Me.actionContainerTools)
        Me.barManager.ActionContainers.Add(Me.actionContainerOptions)
        Me.barManager.ActionContainers.Add(Me.actionContainerDiagnostic)
        Me.barManager.ActionContainers.Add(Me.actionContainerAbout)
        Me.barManager.ActionContainers.Add(Me.actionContainerMenu)
        Me.barManager.ActionContainers.Add(Me.BarLinkActionControlContainer1)
        Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me._mainMenuBar, Me.standardToolBar, Me._statusBar})
        Me.barManager.DockControls.Add(Me.barDockControlTop)
        Me.barManager.DockControls.Add(Me.barDockControlBottom)
        Me.barManager.DockControls.Add(Me.barDockControlLeft)
        Me.barManager.DockControls.Add(Me.barDockControlRight)
        Me.barManager.Form = Me
        Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barSubItemFile, Me.barSubItemEdit, Me.barSubItemView, Me.barSubItemTools, Me.barSubItemHelp, Me.barContainerFile, Me.barContainerObjectsCreation, Me.barContainerClose, Me.barContainerSave, Me.barContainerEdit, Me.barContainerOpenObject, Me.barContainerUndoRedo, Me.barContainerReports, Me.barContainerPrint, Me.barContainerExport, Me.barContainerMenu, Me.barContainerRecordEdit, Me.barContainerWorkflow, Me.barContainerRecordsNavigation, Me.barContainerSearch, Me.barContainerFullTextSearch, Me.barContainerFilters, Me.barContainerView, Me.barContainerTools, Me.barContainerOptions, Me.barContainerDiagnostic, Me.barContainerAbout, Me.barContainerStatusMessages, Me.BarSubItem1, Me.BarLinkContainerExItem1})
        Me.barManager.MainMenu = Me._mainMenuBar
        Me.barManager.MaxItemId = 26
        Me.barManager.StatusBar = Me._statusBar
        '
        'actionContainerObjectsCreation
        '
        Me.actionContainerObjectsCreation.ActionCategory = "ObjectsCreation"
        Me.actionContainerObjectsCreation.BarContainerItem = Me.barContainerObjectsCreation
        '
        'barContainerObjectsCreation
        '
        resources.ApplyResources(Me.barContainerObjectsCreation, "barContainerObjectsCreation")
        Me.barContainerObjectsCreation.Id = 17
        Me.barContainerObjectsCreation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerObjectsCreation.Name = "barContainerObjectsCreation"
        '
        'actionContainerFile
        '
        Me.actionContainerFile.ActionCategory = "File"
        Me.actionContainerFile.BarContainerItem = Me.barContainerFile
        '
        'barContainerFile
        '
        resources.ApplyResources(Me.barContainerFile, "barContainerFile")
        Me.barContainerFile.Id = 5
        Me.barContainerFile.MergeOrder = 2
        Me.barContainerFile.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerFile.Name = "barContainerFile"
        '
        'actionContainerClose
        '
        Me.actionContainerClose.ActionCategory = "Close"
        Me.actionContainerClose.BarContainerItem = Me.barContainerClose
        '
        'barContainerClose
        '
        resources.ApplyResources(Me.barContainerClose, "barContainerClose")
        Me.barContainerClose.Id = 18
        Me.barContainerClose.MergeOrder = 2
        Me.barContainerClose.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerClose.Name = "barContainerClose"
        '
        'actionContainerSave
        '
        Me.actionContainerSave.ActionCategory = "Save"
        Me.actionContainerSave.BarContainerItem = Me.barContainerSave
        '
        'barContainerSave
        '
        resources.ApplyResources(Me.barContainerSave, "barContainerSave")
        Me.barContainerSave.Id = 17
        Me.barContainerSave.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerSave.Name = "barContainerSave"
        '
        'actionContainerExport
        '
        Me.actionContainerExport.ActionCategory = "Export"
        Me.actionContainerExport.BarContainerItem = Me.barContainerExport
        '
        'barContainerExport
        '
        resources.ApplyResources(Me.barContainerExport, "barContainerExport")
        Me.barContainerExport.Id = 7
        Me.barContainerExport.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerExport.Name = "barContainerExport"
        '
        'actionContainerPrint
        '
        Me.actionContainerPrint.ActionCategory = "Print"
        Me.actionContainerPrint.BarContainerItem = Me.barContainerPrint
        '
        'barContainerPrint
        '
        resources.ApplyResources(Me.barContainerPrint, "barContainerPrint")
        Me.barContainerPrint.Id = 6
        Me.barContainerPrint.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerPrint.Name = "barContainerPrint"
        '
        'actionContainerUndoRedo
        '
        Me.actionContainerUndoRedo.ActionCategory = "UndoRedo"
        Me.actionContainerUndoRedo.BarContainerItem = Me.barContainerUndoRedo
        '
        'barContainerUndoRedo
        '
        resources.ApplyResources(Me.barContainerUndoRedo, "barContainerUndoRedo")
        Me.barContainerUndoRedo.Id = 19
        Me.barContainerUndoRedo.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerUndoRedo.Name = "barContainerUndoRedo"
        '
        'actionContainerEdit
        '
        Me.actionContainerEdit.ActionCategory = "Edit"
        Me.actionContainerEdit.BarContainerItem = Me.barContainerEdit
        '
        'barContainerEdit
        '
        resources.ApplyResources(Me.barContainerEdit, "barContainerEdit")
        Me.barContainerEdit.Id = 18
        Me.barContainerEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerEdit.Name = "barContainerEdit"
        '
        'actionContainerRecordEdit
        '
        Me.actionContainerRecordEdit.ActionCategory = "RecordEdit"
        Me.actionContainerRecordEdit.BarContainerItem = Me.barContainerRecordEdit
        '
        'barContainerRecordEdit
        '
        resources.ApplyResources(Me.barContainerRecordEdit, "barContainerRecordEdit")
        Me.barContainerRecordEdit.Id = 9
        Me.barContainerRecordEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerRecordEdit.Name = "barContainerRecordEdit"
        '
        'actionContainerWorkflow
        '
        Me.actionContainerWorkflow.ActionCategory = "Workflow"
        Me.actionContainerWorkflow.BarContainerItem = Me.barContainerWorkflow
        '
        'barContainerWorkflow
        '
        resources.ApplyResources(Me.barContainerWorkflow, "barContainerWorkflow")
        Me.barContainerWorkflow.Id = 9
        Me.barContainerWorkflow.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerWorkflow.Name = "barContainerWorkflow"
        '
        'actionContainerOpenObject
        '
        Me.actionContainerOpenObject.ActionCategory = "OpenObject"
        Me.actionContainerOpenObject.BarContainerItem = Me.barContainerOpenObject
        '
        'barContainerOpenObject
        '
        resources.ApplyResources(Me.barContainerOpenObject, "barContainerOpenObject")
        Me.barContainerOpenObject.Id = 20
        Me.barContainerOpenObject.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerOpenObject.Name = "barContainerOpenObject"
        '
        'actionContainerRecordsNavigation
        '
        Me.actionContainerRecordsNavigation.ActionCategory = "RecordsNavigation"
        Me.actionContainerRecordsNavigation.BarContainerItem = Me.barContainerRecordsNavigation
        '
        'barContainerRecordsNavigation
        '
        resources.ApplyResources(Me.barContainerRecordsNavigation, "barContainerRecordsNavigation")
        Me.barContainerRecordsNavigation.Id = 10
        Me.barContainerRecordsNavigation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerRecordsNavigation.Name = "barContainerRecordsNavigation"
        '
        'actionContainerView
        '
        Me.actionContainerView.ActionCategory = "View"
        Me.actionContainerView.BarContainerItem = Me.barContainerView
        '
        'barContainerView
        '
        resources.ApplyResources(Me.barContainerView, "barContainerView")
        Me.barContainerView.Id = 12
        Me.barContainerView.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerView.Name = "barContainerView"
        '
        'actionContainerReports
        '
        Me.actionContainerReports.ActionCategory = "Reports"
        Me.actionContainerReports.BarContainerItem = Me.barContainerReports
        '
        'barContainerReports
        '
        resources.ApplyResources(Me.barContainerReports, "barContainerReports")
        Me.barContainerReports.Id = 20
        Me.barContainerReports.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerReports.Name = "barContainerReports"
        '
        'actionContainerSearch
        '
        Me.actionContainerSearch.ActionCategory = "Search"
        Me.actionContainerSearch.BarContainerItem = Me.barContainerSearch
        '
        'barContainerSearch
        '
        resources.ApplyResources(Me.barContainerSearch, "barContainerSearch")
        Me.barContainerSearch.Id = 11
        Me.barContainerSearch.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerSearch.Name = "barContainerSearch"
        '
        'actionContainerFullTextSearch
        '
        Me.actionContainerFullTextSearch.ActionCategory = "FullTextSearch"
        Me.actionContainerFullTextSearch.BarContainerItem = Me.barContainerFullTextSearch
        '
        'barContainerFullTextSearch
        '
        Me.barContainerFullTextSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        resources.ApplyResources(Me.barContainerFullTextSearch, "barContainerFullTextSearch")
        Me.barContainerFullTextSearch.Id = 12
        Me.barContainerFullTextSearch.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerFullTextSearch.Name = "barContainerFullTextSearch"
        '
        'actionContainerFilters
        '
        Me.actionContainerFilters.ActionCategory = "Filters"
        Me.actionContainerFilters.BarContainerItem = Me.barContainerFilters
        '
        'barContainerFilters
        '
        resources.ApplyResources(Me.barContainerFilters, "barContainerFilters")
        Me.barContainerFilters.Id = 26
        Me.barContainerFilters.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerFilters.Name = "barContainerFilters"
        '
        'actionContainerTools
        '
        Me.actionContainerTools.ActionCategory = "Tools"
        Me.actionContainerTools.BarContainerItem = Me.barContainerTools
        Me.actionContainerTools.IsMenuMode = True
        '
        'barContainerTools
        '
        resources.ApplyResources(Me.barContainerTools, "barContainerTools")
        Me.barContainerTools.Id = 13
        Me.barContainerTools.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerTools.Name = "barContainerTools"
        '
        'actionContainerOptions
        '
        Me.actionContainerOptions.ActionCategory = "Options"
        Me.actionContainerOptions.BarContainerItem = Me.barContainerOptions
        Me.actionContainerOptions.IsMenuMode = True
        '
        'barContainerOptions
        '
        resources.ApplyResources(Me.barContainerOptions, "barContainerOptions")
        Me.barContainerOptions.Id = 14
        Me.barContainerOptions.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerOptions.Name = "barContainerOptions"
        '
        'actionContainerDiagnostic
        '
        Me.actionContainerDiagnostic.ActionCategory = "Diagnostic"
        Me.actionContainerDiagnostic.BarContainerItem = Me.barContainerDiagnostic
        Me.actionContainerDiagnostic.IsMenuMode = True
        '
        'barContainerDiagnostic
        '
        resources.ApplyResources(Me.barContainerDiagnostic, "barContainerDiagnostic")
        Me.barContainerDiagnostic.Id = 16
        Me.barContainerDiagnostic.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerDiagnostic.Name = "barContainerDiagnostic"
        '
        'actionContainerAbout
        '
        Me.actionContainerAbout.ActionCategory = "About"
        Me.actionContainerAbout.BarContainerItem = Me.barContainerAbout
        Me.actionContainerAbout.IsMenuMode = True
        '
        'barContainerAbout
        '
        resources.ApplyResources(Me.barContainerAbout, "barContainerAbout")
        Me.barContainerAbout.Id = 15
        Me.barContainerAbout.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerAbout.Name = "barContainerAbout"
        '
        'actionContainerMenu
        '
        Me.actionContainerMenu.ActionCategory = "Menu"
        Me.actionContainerMenu.BarContainerItem = Me.barContainerMenu
        '
        'barContainerMenu
        '
        resources.ApplyResources(Me.barContainerMenu, "barContainerMenu")
        Me.barContainerMenu.Id = 8
        Me.barContainerMenu.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerMenu.Name = "barContainerMenu"
        '
        '_mainMenuBar
        '
        Me._mainMenuBar.BarName = "Main Menu"
        Me._mainMenuBar.DockCol = 0
        Me._mainMenuBar.DockRow = 0
        Me._mainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me._mainMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemFile), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemView), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemTools), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemHelp), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1)})
        Me._mainMenuBar.OptionsBar.MultiLine = True
        Me._mainMenuBar.OptionsBar.UseWholeRow = True
        resources.ApplyResources(Me._mainMenuBar, "_mainMenuBar")
        '
        'barSubItemFile
        '
        resources.ApplyResources(Me.barSubItemFile, "barSubItemFile")
        Me.barSubItemFile.HideWhenEmpty = True
        Me.barSubItemFile.Id = 0
        Me.barSubItemFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerClose, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerExport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerPrint, True)})
        Me.barSubItemFile.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemFile.Name = "barSubItemFile"
        '
        'barSubItemEdit
        '
        resources.ApplyResources(Me.barSubItemEdit, "barSubItemEdit")
        Me.barSubItemEdit.HideWhenEmpty = True
        Me.barSubItemEdit.Id = 1
        Me.barSubItemEdit.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerUndoRedo, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerRecordEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerWorkflow, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerOpenObject, True)})
        Me.barSubItemEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemEdit.Name = "barSubItemEdit"
        '
        'barSubItemView
        '
        resources.ApplyResources(Me.barSubItemView, "barSubItemView")
        Me.barSubItemView.HideWhenEmpty = True
        Me.barSubItemView.Id = 2
        Me.barSubItemView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerRecordsNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerView, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerReports, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerSearch, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.barContainerFullTextSearch, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.barContainerFilters, True)})
        Me.barSubItemView.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemView.Name = "barSubItemView"
        '
        'barSubItemTools
        '
        resources.ApplyResources(Me.barSubItemTools, "barSubItemTools")
        Me.barSubItemTools.HideWhenEmpty = True
        Me.barSubItemTools.Id = 3
        Me.barSubItemTools.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerTools, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerOptions, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerDiagnostic, True)})
        Me.barSubItemTools.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemTools.Name = "barSubItemTools"
        '
        'barSubItemHelp
        '
        resources.ApplyResources(Me.barSubItemHelp, "barSubItemHelp")
        Me.barSubItemHelp.HideWhenEmpty = True
        Me.barSubItemHelp.Id = 4
        Me.barSubItemHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerAbout, True)})
        Me.barSubItemHelp.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemHelp.Name = "barSubItemHelp"
        '
        'standardToolBar
        '
        Me.standardToolBar.BarName = "Main Toolbar"
        Me.standardToolBar.DockCol = 0
        Me.standardToolBar.DockRow = 1
        Me.standardToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.standardToolBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerUndoRedo, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerRecordEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerOpenObject), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerWorkflow, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerView, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerReports), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerRecordsNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerClose, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerFilters, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerSearch, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerFullTextSearch)})
        Me.standardToolBar.OptionsBar.UseWholeRow = True
        resources.ApplyResources(Me.standardToolBar, "standardToolBar")
        '
        '_statusBar
        '
        Me._statusBar.BarName = "StatusBar"
        Me._statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me._statusBar.DockCol = 0
        Me._statusBar.DockRow = 0
        Me._statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me._statusBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerStatusMessages)})
        Me._statusBar.OptionsBar.AllowQuickCustomization = False
        Me._statusBar.OptionsBar.DisableClose = True
        Me._statusBar.OptionsBar.DisableCustomization = True
        Me._statusBar.OptionsBar.DrawDragBorder = False
        Me._statusBar.OptionsBar.DrawSizeGrip = True
        Me._statusBar.OptionsBar.UseWholeRow = True
        resources.ApplyResources(Me._statusBar, "_statusBar")
        '
        'barContainerStatusMessages
        '
        resources.ApplyResources(Me.barContainerStatusMessages, "barContainerStatusMessages")
        Me.barContainerStatusMessages.Id = 23
        Me.barContainerStatusMessages.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerStatusMessages.Name = "barContainerStatusMessages"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        resources.ApplyResources(Me.barDockControlTop, "barDockControlTop")
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        resources.ApplyResources(Me.barDockControlBottom, "barDockControlBottom")
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        resources.ApplyResources(Me.barDockControlLeft, "barDockControlLeft")
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        resources.ApplyResources(Me.barDockControlRight, "barDockControlRight")
        '
        'modelSynchronizationManager
        '
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.formStateModelSynchronizer)
        '
        'formStateModelSynchronizer
        '
        Me.formStateModelSynchronizer.Form = Me
        '
        'viewSiteManager
        '
        Me.viewSiteManager.ViewSiteControl = Me.viewSitePanel
        '
        'viewSitePanel
        '
        Me.viewSitePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        resources.ApplyResources(Me.viewSitePanel, "viewSitePanel")
        Me.viewSitePanel.Name = "viewSitePanel"
        '
        'templateContextMenu
        '
        Me.templateContextMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerOpenObject, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerUndoRedo, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerReports, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerClose, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerRecordEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerView, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerPrint, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerExport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barContainerMenu, True)})
        Me.templateContextMenu.Manager = Me.barManager
        Me.templateContextMenu.Name = "templateContextMenu"
        '
        'BarSubItem1
        '
        resources.ApplyResources(Me.BarSubItem1, "BarSubItem1")
        Me.BarSubItem1.Id = 24
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarLinkContainerExItem1)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarLinkContainerExItem1
        '
        resources.ApplyResources(Me.BarLinkContainerExItem1, "BarLinkContainerExItem1")
        Me.BarLinkContainerExItem1.Id = 25
        Me.BarLinkContainerExItem1.Name = "BarLinkContainerExItem1"
        '
        'BarLinkActionControlContainer1
        '
        Me.BarLinkActionControlContainer1.ActionCategory = "My Actions"
        Me.BarLinkActionControlContainer1.BarContainerItem = Me.BarLinkContainerExItem1
        '
        'DetailForm1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.viewSitePanel)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "DetailForm1"
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerObjectsCreation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerUndoRedo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerRecordEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerWorkflow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerOpenObject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerRecordsNavigation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerFullTextSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerTools, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerDiagnostic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.actionContainerMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.templateContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLinkActionControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private barManager As DevExpress.ExpressApp.Win.Templates.Bars.XafBarManagerV2
    Private viewSitePanel As DevExpress.XtraEditors.PanelControl
    Private formStateModelSynchronizer As DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer
    Private modelSynchronizationManager As DevExpress.ExpressApp.Win.Templates.ModelSynchronizationManager
    Private viewSiteManager As DevExpress.ExpressApp.Win.Templates.ViewSiteManager
    Private barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private _mainMenuBar As DevExpress.XtraBars.Bar
    Private standardToolBar As DevExpress.XtraBars.Bar
    Private _statusBar As DevExpress.XtraBars.Bar
    Private barSubItemFile As DevExpress.XtraBars.BarSubItem
    Private barSubItemEdit As DevExpress.XtraBars.BarSubItem
    Private barSubItemView As DevExpress.XtraBars.BarSubItem
    Private barSubItemTools As DevExpress.XtraBars.BarSubItem
    Private barSubItemHelp As DevExpress.XtraBars.BarSubItem
    Private templateContextMenu As DevExpress.XtraBars.PopupMenu
    Private barContainerFile As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerObjectsCreation As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerClose As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerSave As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerEdit As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerOpenObject As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerUndoRedo As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerReports As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerPrint As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerExport As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerMenu As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerRecordEdit As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerWorkflow As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerRecordsNavigation As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerSearch As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerFullTextSearch As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerFilters As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerView As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerTools As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerOptions As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerAbout As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerDiagnostic As DevExpress.XtraBars.BarLinkContainerExItem
    Private actionContainerFile As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerObjectsCreation As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerClose As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerSave As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerEdit As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerOpenObject As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerUndoRedo As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerReports As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerPrint As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerExport As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerRecordEdit As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerWorkflow As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerRecordsNavigation As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerSearch As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerFullTextSearch As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerFilters As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerView As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerTools As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerOptions As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerAbout As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerDiagnostic As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private actionContainerMenu As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barContainerStatusMessages As DevExpress.XtraBars.BarLinkContainerExItem
    Friend WithEvents BarLinkActionControlContainer1 As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Friend WithEvents BarLinkContainerExItem1 As DevExpress.XtraBars.BarLinkContainerExItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
End Class
