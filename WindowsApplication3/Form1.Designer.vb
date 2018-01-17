<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ddlCharRace = New System.Windows.Forms.ComboBox()
        Me.ddlCharJob = New System.Windows.Forms.ComboBox()
        Me.ddlFragCharRace = New System.Windows.Forms.ComboBox()
        Me.boxSkillBreakdown = New System.Windows.Forms.TextBox()
        Me.numericBlanketAmt = New System.Windows.Forms.NumericUpDown()
        Me.boxTotalCP = New System.Windows.Forms.TextBox()
        Me.boxSpentCP = New System.Windows.Forms.TextBox()
        Me.boxFreeCP = New System.Windows.Forms.TextBox()
        Me.boxPlayerName = New System.Windows.Forms.TextBox()
        Me.boxCharName = New System.Windows.Forms.TextBox()
        Me.boxLevel = New System.Windows.Forms.TextBox()
        Me.boxHP = New System.Windows.Forms.TextBox()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblCharName = New System.Windows.Forms.Label()
        Me.lblCharRace = New System.Windows.Forms.Label()
        Me.lblBlankets = New System.Windows.Forms.Label()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.lblSpentCP = New System.Windows.Forms.Label()
        Me.lblFreeCP = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblSkillBreakdown = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSaveAsText = New System.Windows.Forms.Button()
        Me.InBox = New System.Windows.Forms.ListBox()
        Me.btnSaveToFile = New System.Windows.Forms.Button()
        Me.ddlFragGuild = New System.Windows.Forms.ComboBox()
        Me.Rogue = New System.Windows.Forms.TabPage()
        Me.lblExecute = New System.Windows.Forms.Label()
        Me.skillGarrote = New System.Windows.Forms.NumericUpDown()
        Me.lblGarrote = New System.Windows.Forms.Label()
        Me.costGarrote = New System.Windows.Forms.Label()
        Me.skillLocksmith = New System.Windows.Forms.NumericUpDown()
        Me.lblLocksmith = New System.Windows.Forms.Label()
        Me.costLocksmith = New System.Windows.Forms.Label()
        Me.skillSap = New System.Windows.Forms.NumericUpDown()
        Me.lblSap = New System.Windows.Forms.Label()
        Me.costSap = New System.Windows.Forms.Label()
        Me.skillDodge = New System.Windows.Forms.NumericUpDown()
        Me.lblDodge = New System.Windows.Forms.Label()
        Me.costDodge = New System.Windows.Forms.Label()
        Me.skillCritSpecific = New System.Windows.Forms.NumericUpDown()
        Me.lblCritSpecific = New System.Windows.Forms.Label()
        Me.costCritSpecific = New System.Windows.Forms.Label()
        Me.ddlCritSpecificWeapon = New System.Windows.Forms.ComboBox()
        Me.skillCritGroup = New System.Windows.Forms.NumericUpDown()
        Me.lblCritGroup = New System.Windows.Forms.Label()
        Me.costCritGroup = New System.Windows.Forms.Label()
        Me.ddlCritGroup = New System.Windows.Forms.ComboBox()
        Me.skillVitalBlow = New System.Windows.Forms.NumericUpDown()
        Me.lblVitalBlow = New System.Windows.Forms.Label()
        Me.costVitalBlow = New System.Windows.Forms.Label()
        Me.skillExecute = New System.Windows.Forms.NumericUpDown()
        Me.costExecute = New System.Windows.Forms.Label()
        Me.ddlExecute = New System.Windows.Forms.ComboBox()
        Me.skillExecuteMaster = New System.Windows.Forms.NumericUpDown()
        Me.lblExecuteMaster = New System.Windows.Forms.Label()
        Me.costExecuteMaster = New System.Windows.Forms.Label()
        Me.ddlExecuteMaster = New System.Windows.Forms.ComboBox()
        Me.Warrior = New System.Windows.Forms.TabPage()
        Me.skillSimpleProf = New System.Windows.Forms.NumericUpDown()
        Me.lblSimpleProf = New System.Windows.Forms.Label()
        Me.costSimpleProf = New System.Windows.Forms.Label()
        Me.lblSlayParry = New System.Windows.Forms.Label()
        Me.lblAmbidexterity = New System.Windows.Forms.Label()
        Me.skillFlorentine = New System.Windows.Forms.NumericUpDown()
        Me.lblFlorentine = New System.Windows.Forms.Label()
        Me.costFlorentine = New System.Windows.Forms.Label()
        Me.skillFlurryOfBlows = New System.Windows.Forms.NumericUpDown()
        Me.lblFlurryofBlows = New System.Windows.Forms.Label()
        Me.costFlurryOfBlows = New System.Windows.Forms.Label()
        Me.skillHeavyArmour = New System.Windows.Forms.NumericUpDown()
        Me.lblHeavyArmour = New System.Windows.Forms.Label()
        Me.costHeavyArmour = New System.Windows.Forms.Label()
        Me.skillSelfMut = New System.Windows.Forms.NumericUpDown()
        Me.lblSelfMut = New System.Windows.Forms.Label()
        Me.costSelfMut = New System.Windows.Forms.Label()
        Me.skillShield = New System.Windows.Forms.NumericUpDown()
        Me.lblShield = New System.Windows.Forms.Label()
        Me.costShield = New System.Windows.Forms.Label()
        Me.skillMedProf = New System.Windows.Forms.NumericUpDown()
        Me.lblMedProf = New System.Windows.Forms.Label()
        Me.costMedProf = New System.Windows.Forms.Label()
        Me.skillLargeProf = New System.Windows.Forms.NumericUpDown()
        Me.lblLargeProf = New System.Windows.Forms.Label()
        Me.costLargeProf = New System.Windows.Forms.Label()
        Me.skillSpecGroup = New System.Windows.Forms.NumericUpDown()
        Me.lblSpecGroup = New System.Windows.Forms.Label()
        Me.costSpecGroup = New System.Windows.Forms.Label()
        Me.skillSpecSpecific = New System.Windows.Forms.NumericUpDown()
        Me.lblSpecSpecific = New System.Windows.Forms.Label()
        Me.costSpecSpecific = New System.Windows.Forms.Label()
        Me.skillExoticProf = New System.Windows.Forms.NumericUpDown()
        Me.lblExoticProf = New System.Windows.Forms.Label()
        Me.costExoticProf = New System.Windows.Forms.Label()
        Me.ddlExoticWeapon = New System.Windows.Forms.ComboBox()
        Me.ddlSpecGroup = New System.Windows.Forms.ComboBox()
        Me.ddlSpecSpecific = New System.Windows.Forms.ComboBox()
        Me.skillSlayParry = New System.Windows.Forms.NumericUpDown()
        Me.costSlayParry = New System.Windows.Forms.Label()
        Me.ddlSlayParryWeapon = New System.Windows.Forms.ComboBox()
        Me.skillSlayParryMaster = New System.Windows.Forms.NumericUpDown()
        Me.lblSlayParryMaster = New System.Windows.Forms.Label()
        Me.costSlayParryMaster = New System.Windows.Forms.Label()
        Me.ddlSlayParryMasterWeapon = New System.Windows.Forms.ComboBox()
        Me.costAmbidexterity = New System.Windows.Forms.Label()
        Me.skillAmbidexterity = New System.Windows.Forms.NumericUpDown()
        Me.skillWeaponRefocus = New System.Windows.Forms.NumericUpDown()
        Me.lblWeaponRefocus = New System.Windows.Forms.Label()
        Me.costWeaponRefocus = New System.Windows.Forms.Label()
        Me.Scholar = New System.Windows.Forms.TabPage()
        Me.lblPyramid = New System.Windows.Forms.Label()
        Me.lblPyramidOrSpinners = New System.Windows.Forms.Label()
        Me.ddlPyramid = New System.Windows.Forms.ComboBox()
        Me.costAdvRitual = New System.Windows.Forms.Label()
        Me.lblAdvRitual = New System.Windows.Forms.Label()
        Me.skillAdvRitual = New System.Windows.Forms.NumericUpDown()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblSpellSlots = New System.Windows.Forms.Label()
        Me.ddlEleAttunement4 = New System.Windows.Forms.ComboBox()
        Me.ddlEleAttunement3 = New System.Windows.Forms.ComboBox()
        Me.ddlEleAttunement2 = New System.Windows.Forms.ComboBox()
        Me.ddlEleAttunement1 = New System.Windows.Forms.ComboBox()
        Me.skillPhysician = New System.Windows.Forms.NumericUpDown()
        Me.skillAnatomy = New System.Windows.Forms.NumericUpDown()
        Me.lblAnatomy = New System.Windows.Forms.Label()
        Me.costAnatomy = New System.Windows.Forms.Label()
        Me.skillMysticism = New System.Windows.Forms.NumericUpDown()
        Me.lblMysticism = New System.Windows.Forms.Label()
        Me.costMysticism = New System.Windows.Forms.Label()
        Me.skillDemonAngelArts = New System.Windows.Forms.NumericUpDown()
        Me.lblDemonAngelArts = New System.Windows.Forms.Label()
        Me.costDemonAngelArts = New System.Windows.Forms.Label()
        Me.skillEleAttunement = New System.Windows.Forms.NumericUpDown()
        Me.lblEleAttunement = New System.Windows.Forms.Label()
        Me.costEleAttunement = New System.Windows.Forms.Label()
        Me.skillFirstAid = New System.Windows.Forms.NumericUpDown()
        Me.lblFirstAid = New System.Windows.Forms.Label()
        Me.costFirstAid = New System.Windows.Forms.Label()
        Me.skillNecroArts = New System.Windows.Forms.NumericUpDown()
        Me.lblNecroArts = New System.Windows.Forms.Label()
        Me.costNecroArts = New System.Windows.Forms.Label()
        Me.lblPhysician = New System.Windows.Forms.Label()
        Me.costPhysician = New System.Windows.Forms.Label()
        Me.skillReadAndWrite = New System.Windows.Forms.NumericUpDown()
        Me.lblReadAndWrite = New System.Windows.Forms.Label()
        Me.costReadAndWrite = New System.Windows.Forms.Label()
        Me.costSpellRitual = New System.Windows.Forms.Label()
        Me.skillReadMagic = New System.Windows.Forms.NumericUpDown()
        Me.lblReadMagic = New System.Windows.Forms.Label()
        Me.costReadMagic = New System.Windows.Forms.Label()
        Me.skillReadMagicAvd = New System.Windows.Forms.NumericUpDown()
        Me.lblReadMagicAvd = New System.Windows.Forms.Label()
        Me.costReadMagicAvd = New System.Windows.Forms.Label()
        Me.lblRitual = New System.Windows.Forms.Label()
        Me.skillReadMagicRitual = New System.Windows.Forms.NumericUpDown()
        Me.lblSpellLevel9 = New System.Windows.Forms.Label()
        Me.lblReadMagicRitual = New System.Windows.Forms.Label()
        Me.lblSpellLevel8 = New System.Windows.Forms.Label()
        Me.costReadMagicRitual = New System.Windows.Forms.Label()
        Me.lblSpellLevel7 = New System.Windows.Forms.Label()
        Me.skillSphere1 = New System.Windows.Forms.NumericUpDown()
        Me.lblSpellLevel6 = New System.Windows.Forms.Label()
        Me.lblSphere1 = New System.Windows.Forms.Label()
        Me.lblSpellLevel5 = New System.Windows.Forms.Label()
        Me.costSphere1 = New System.Windows.Forms.Label()
        Me.lblSpellLevel4 = New System.Windows.Forms.Label()
        Me.skillSphere2 = New System.Windows.Forms.NumericUpDown()
        Me.lblSpellLevel3 = New System.Windows.Forms.Label()
        Me.lblSphere2 = New System.Windows.Forms.Label()
        Me.lblSpellLevel2 = New System.Windows.Forms.Label()
        Me.costSphere2 = New System.Windows.Forms.Label()
        Me.lblSpellLevel1 = New System.Windows.Forms.Label()
        Me.skillSphere3 = New System.Windows.Forms.NumericUpDown()
        Me.lblSphere3 = New System.Windows.Forms.Label()
        Me.costSphere3 = New System.Windows.Forms.Label()
        Me.ddlSphere1 = New System.Windows.Forms.ComboBox()
        Me.ddlSphere2 = New System.Windows.Forms.ComboBox()
        Me.ddlSphere3 = New System.Windows.Forms.ComboBox()
        Me.skillSpellRitual = New System.Windows.Forms.NumericUpDown()
        Me.skillSpell1 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpell2 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpell3 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpell4 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpell5 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpell9 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpell8 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpell7 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpell6 = New System.Windows.Forms.NumericUpDown()
        Me.CostRitualCircle = New System.Windows.Forms.Label()
        Me.costSpell1 = New System.Windows.Forms.Label()
        Me.costSpell2 = New System.Windows.Forms.Label()
        Me.costSpell3 = New System.Windows.Forms.Label()
        Me.costSpell4 = New System.Windows.Forms.Label()
        Me.costSpell5 = New System.Windows.Forms.Label()
        Me.costSpell6 = New System.Windows.Forms.Label()
        Me.costSpell7 = New System.Windows.Forms.Label()
        Me.costSpell8 = New System.Windows.Forms.Label()
        Me.costSpell9 = New System.Windows.Forms.Label()
        Me.JobRaceProd = New System.Windows.Forms.TabPage()
        Me.lblSpellVersa9 = New System.Windows.Forms.Label()
        Me.lblSpellVersa8 = New System.Windows.Forms.Label()
        Me.lblSpellVersa7 = New System.Windows.Forms.Label()
        Me.lblSpellVersa6 = New System.Windows.Forms.Label()
        Me.lblSpellVersa5 = New System.Windows.Forms.Label()
        Me.lblSpellVersa4 = New System.Windows.Forms.Label()
        Me.lblSpellVersa3 = New System.Windows.Forms.Label()
        Me.lblSpellVersa2 = New System.Windows.Forms.Label()
        Me.lblSpellVersa1 = New System.Windows.Forms.Label()
        Me.skillSpellVersa1 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpellVersa2 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpellVersa3 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpellVersa4 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpellVersa5 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpellVersa9 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpellVersa8 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpellVersa7 = New System.Windows.Forms.NumericUpDown()
        Me.skillSpellVersa6 = New System.Windows.Forms.NumericUpDown()
        Me.costSpellVersa1 = New System.Windows.Forms.Label()
        Me.costSpellVersa2 = New System.Windows.Forms.Label()
        Me.costSpellVersa3 = New System.Windows.Forms.Label()
        Me.costSpellVersa4 = New System.Windows.Forms.Label()
        Me.costSpellVersa5 = New System.Windows.Forms.Label()
        Me.costSpellVersa6 = New System.Windows.Forms.Label()
        Me.costSpellVersa7 = New System.Windows.Forms.Label()
        Me.costSpellVersa8 = New System.Windows.Forms.Label()
        Me.costSpellVersa9 = New System.Windows.Forms.Label()
        Me.lblSpellVersa = New System.Windows.Forms.Label()
        Me.skillHeavyDrinker = New System.Windows.Forms.NumericUpDown()
        Me.costHeavyDrinker = New System.Windows.Forms.Label()
        Me.lblHeavyDrinker = New System.Windows.Forms.Label()
        Me.skillFrag6 = New System.Windows.Forms.NumericUpDown()
        Me.skillFrag5 = New System.Windows.Forms.NumericUpDown()
        Me.skillFrag4 = New System.Windows.Forms.NumericUpDown()
        Me.B64a = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.B64b = New System.Windows.Forms.TextBox()
        Me.boxCraft4 = New System.Windows.Forms.TextBox()
        Me.boxCraft3 = New System.Windows.Forms.TextBox()
        Me.boxCraft2 = New System.Windows.Forms.TextBox()
        Me.boxCraft1 = New System.Windows.Forms.TextBox()
        Me.skillCraft4 = New System.Windows.Forms.NumericUpDown()
        Me.lblCraft4 = New System.Windows.Forms.Label()
        Me.costCraft4 = New System.Windows.Forms.Label()
        Me.skillcraft3 = New System.Windows.Forms.NumericUpDown()
        Me.lblCraft3 = New System.Windows.Forms.Label()
        Me.costCraft3 = New System.Windows.Forms.Label()
        Me.skillCraft2 = New System.Windows.Forms.NumericUpDown()
        Me.lblCraft2 = New System.Windows.Forms.Label()
        Me.costCraft2 = New System.Windows.Forms.Label()
        Me.costFavoured = New System.Windows.Forms.Label()
        Me.FavouredCheck = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblRaceSkills = New System.Windows.Forms.Label()
        Me.lblJob = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.skillFrag1 = New System.Windows.Forms.NumericUpDown()
        Me.lblFrag1 = New System.Windows.Forms.Label()
        Me.costFrag1 = New System.Windows.Forms.Label()
        Me.skillFrag2 = New System.Windows.Forms.NumericUpDown()
        Me.lblFrag2 = New System.Windows.Forms.Label()
        Me.costFrag2 = New System.Windows.Forms.Label()
        Me.costFrag6 = New System.Windows.Forms.Label()
        Me.skillFrag3 = New System.Windows.Forms.NumericUpDown()
        Me.costFrag5 = New System.Windows.Forms.Label()
        Me.lblFrag3 = New System.Windows.Forms.Label()
        Me.costFrag4 = New System.Windows.Forms.Label()
        Me.costFrag3 = New System.Windows.Forms.Label()
        Me.skillLooting = New System.Windows.Forms.NumericUpDown()
        Me.lblFrag6 = New System.Windows.Forms.Label()
        Me.lblLooting = New System.Windows.Forms.Label()
        Me.lblFrag5 = New System.Windows.Forms.Label()
        Me.costLooting = New System.Windows.Forms.Label()
        Me.lblFrag4 = New System.Windows.Forms.Label()
        Me.lblJob1 = New System.Windows.Forms.Label()
        Me.skillJob1 = New System.Windows.Forms.NumericUpDown()
        Me.costJob1 = New System.Windows.Forms.Label()
        Me.skillJob2 = New System.Windows.Forms.NumericUpDown()
        Me.lblJob2 = New System.Windows.Forms.Label()
        Me.costJob2 = New System.Windows.Forms.Label()
        Me.skillJob3 = New System.Windows.Forms.NumericUpDown()
        Me.lblJob3 = New System.Windows.Forms.Label()
        Me.costJob3 = New System.Windows.Forms.Label()
        Me.skillJob4 = New System.Windows.Forms.NumericUpDown()
        Me.lblJob4 = New System.Windows.Forms.Label()
        Me.costJob4 = New System.Windows.Forms.Label()
        Me.skillRacial2 = New System.Windows.Forms.NumericUpDown()
        Me.lblRacial2 = New System.Windows.Forms.Label()
        Me.costRacial2 = New System.Windows.Forms.Label()
        Me.skillBPB = New System.Windows.Forms.NumericUpDown()
        Me.lblBPB = New System.Windows.Forms.Label()
        Me.costBPB = New System.Windows.Forms.Label()
        Me.skillStr = New System.Windows.Forms.NumericUpDown()
        Me.lblStr = New System.Windows.Forms.Label()
        Me.costStr = New System.Windows.Forms.Label()
        Me.skillRacial1 = New System.Windows.Forms.NumericUpDown()
        Me.lblRacial1 = New System.Windows.Forms.Label()
        Me.costRacial1 = New System.Windows.Forms.Label()
        Me.listRacial = New System.Windows.Forms.ComboBox()
        Me.lblBlacksmith = New System.Windows.Forms.Label()
        Me.skillAlchemy = New System.Windows.Forms.NumericUpDown()
        Me.lblAlchemy = New System.Windows.Forms.Label()
        Me.costAlchemy = New System.Windows.Forms.Label()
        Me.skillBlacksmith = New System.Windows.Forms.NumericUpDown()
        Me.costBlacksmith = New System.Windows.Forms.Label()
        Me.skillCraft1 = New System.Windows.Forms.NumericUpDown()
        Me.lblCraft1 = New System.Windows.Forms.Label()
        Me.costCraft1 = New System.Windows.Forms.Label()
        Me.skillCreateScroll = New System.Windows.Forms.NumericUpDown()
        Me.lblCreateScroll = New System.Windows.Forms.Label()
        Me.costCreateScroll = New System.Windows.Forms.Label()
        Me.skillTrapsmith = New System.Windows.Forms.NumericUpDown()
        Me.lblTrapsmith = New System.Windows.Forms.Label()
        Me.costTrapsmith = New System.Windows.Forms.Label()
        Me.boxFragsTotal = New System.Windows.Forms.TextBox()
        Me.lblFrags = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.lblCharClass = New System.Windows.Forms.Label()
        Me.chkVocation = New System.Windows.Forms.CheckBox()
        Me.ddlVocation = New System.Windows.Forms.ComboBox()
        Me.lblWarning = New System.Windows.Forms.Label()
        CType(Me.numericBlanketAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Rogue.SuspendLayout()
        CType(Me.skillGarrote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillLocksmith, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillDodge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillCritSpecific, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillCritGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillVitalBlow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillExecute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillExecuteMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Warrior.SuspendLayout()
        CType(Me.skillSimpleProf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillFlorentine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillFlurryOfBlows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillHeavyArmour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSelfMut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillShield, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillMedProf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillLargeProf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpecGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpecSpecific, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillExoticProf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSlayParry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSlayParryMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillAmbidexterity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillWeaponRefocus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Scholar.SuspendLayout()
        CType(Me.skillAdvRitual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillPhysician, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillAnatomy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillMysticism, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillDemonAngelArts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillEleAttunement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillFirstAid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillNecroArts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillReadAndWrite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillReadMagic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillReadMagicAvd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillReadMagicRitual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSphere1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSphere2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSphere3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpellRitual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpell1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpell2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpell3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpell4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpell5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpell9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpell8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpell7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpell6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JobRaceProd.SuspendLayout()
        CType(Me.skillSpellVersa1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpellVersa2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpellVersa3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpellVersa4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpellVersa5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpellVersa9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpellVersa8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpellVersa7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillSpellVersa6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillHeavyDrinker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillFrag6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillFrag5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillFrag4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillCraft4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillcraft3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillCraft2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillFrag1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillFrag2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillFrag3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillLooting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillJob1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillJob2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillJob3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillJob4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillRacial2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillBPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillStr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillRacial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillAlchemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillBlacksmith, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillCraft1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillCreateScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skillTrapsmith, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'ddlCharRace
        '
        Me.ddlCharRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlCharRace.FormattingEnabled = True
        Me.ddlCharRace.Items.AddRange(New Object() {"Ajaunti", "Dark Elf", "Einher", "Gargylen", "High Elf", "Hobling", "Human", "Mountain Dwarf", "Orc", "Savar", "Wild Elf", "Wood Fae", "FRAG RACE"})
        Me.ddlCharRace.Location = New System.Drawing.Point(14, 134)
        Me.ddlCharRace.Name = "ddlCharRace"
        Me.ddlCharRace.Size = New System.Drawing.Size(100, 21)
        Me.ddlCharRace.TabIndex = 2
        '
        'ddlCharJob
        '
        Me.ddlCharJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlCharJob.FormattingEnabled = True
        Me.ddlCharJob.Items.AddRange(New Object() {"Mercenary", "Ranger", "Templar", "Nightblade", "Assassin", "Witchhunter", "Mage", "Druid", "Bard", "Dread Knight", "Paladin", "Darkweaver", "Lightweaver", "Dragon Knight"})
        Me.ddlCharJob.Location = New System.Drawing.Point(13, 177)
        Me.ddlCharJob.Name = "ddlCharJob"
        Me.ddlCharJob.Size = New System.Drawing.Size(100, 21)
        Me.ddlCharJob.TabIndex = 3
        '
        'ddlFragCharRace
        '
        Me.ddlFragCharRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlFragCharRace.FormattingEnabled = True
        Me.ddlFragCharRace.Items.AddRange(New Object() {"Avian", "Carnal Fae", "Draconian", "Faceless", "Faun", "Firbolg", "Fire Elf", "Gnome", "Goblin", "Ice Elf", "Kobold", "Minotaur", "Ogre", "Pax Mordibish", "Risen", "Sidhe", "Squamata", "Stone Elf", "Vulcan Dwarf", "Wolven"})
        Me.ddlFragCharRace.Location = New System.Drawing.Point(119, 134)
        Me.ddlFragCharRace.Name = "ddlFragCharRace"
        Me.ddlFragCharRace.Size = New System.Drawing.Size(100, 21)
        Me.ddlFragCharRace.TabIndex = 2
        '
        'boxSkillBreakdown
        '
        Me.boxSkillBreakdown.BackColor = System.Drawing.SystemColors.ControlLight
        Me.boxSkillBreakdown.Location = New System.Drawing.Point(14, 330)
        Me.boxSkillBreakdown.Multiline = True
        Me.boxSkillBreakdown.Name = "boxSkillBreakdown"
        Me.boxSkillBreakdown.ReadOnly = True
        Me.boxSkillBreakdown.Size = New System.Drawing.Size(220, 222)
        Me.boxSkillBreakdown.TabIndex = 3
        Me.boxSkillBreakdown.TabStop = False
        '
        'numericBlanketAmt
        '
        Me.numericBlanketAmt.Location = New System.Drawing.Point(14, 247)
        Me.numericBlanketAmt.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numericBlanketAmt.Name = "numericBlanketAmt"
        Me.numericBlanketAmt.Size = New System.Drawing.Size(48, 20)
        Me.numericBlanketAmt.TabIndex = 4
        Me.numericBlanketAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'boxTotalCP
        '
        Me.boxTotalCP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxTotalCP.Location = New System.Drawing.Point(67, 247)
        Me.boxTotalCP.Name = "boxTotalCP"
        Me.boxTotalCP.ReadOnly = True
        Me.boxTotalCP.Size = New System.Drawing.Size(48, 20)
        Me.boxTotalCP.TabIndex = 5
        Me.boxTotalCP.TabStop = False
        '
        'boxSpentCP
        '
        Me.boxSpentCP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxSpentCP.Location = New System.Drawing.Point(119, 247)
        Me.boxSpentCP.Name = "boxSpentCP"
        Me.boxSpentCP.ReadOnly = True
        Me.boxSpentCP.Size = New System.Drawing.Size(48, 20)
        Me.boxSpentCP.TabIndex = 6
        Me.boxSpentCP.TabStop = False
        '
        'boxFreeCP
        '
        Me.boxFreeCP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxFreeCP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.boxFreeCP.Location = New System.Drawing.Point(171, 247)
        Me.boxFreeCP.Name = "boxFreeCP"
        Me.boxFreeCP.ReadOnly = True
        Me.boxFreeCP.Size = New System.Drawing.Size(48, 20)
        Me.boxFreeCP.TabIndex = 7
        Me.boxFreeCP.TabStop = False
        '
        'boxPlayerName
        '
        Me.boxPlayerName.Location = New System.Drawing.Point(14, 30)
        Me.boxPlayerName.Name = "boxPlayerName"
        Me.boxPlayerName.Size = New System.Drawing.Size(205, 20)
        Me.boxPlayerName.TabIndex = 0
        '
        'boxCharName
        '
        Me.boxCharName.Location = New System.Drawing.Point(14, 82)
        Me.boxCharName.Name = "boxCharName"
        Me.boxCharName.Size = New System.Drawing.Size(205, 20)
        Me.boxCharName.TabIndex = 1
        '
        'boxLevel
        '
        Me.boxLevel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxLevel.Location = New System.Drawing.Point(14, 286)
        Me.boxLevel.Name = "boxLevel"
        Me.boxLevel.ReadOnly = True
        Me.boxLevel.Size = New System.Drawing.Size(48, 20)
        Me.boxLevel.TabIndex = 21
        Me.boxLevel.TabStop = False
        '
        'boxHP
        '
        Me.boxHP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxHP.Location = New System.Drawing.Point(68, 286)
        Me.boxHP.Name = "boxHP"
        Me.boxHP.ReadOnly = True
        Me.boxHP.Size = New System.Drawing.Size(48, 20)
        Me.boxHP.TabIndex = 229
        Me.boxHP.TabStop = False
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(18, 14)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(78, 13)
        Me.lblPlayerName.TabIndex = 230
        Me.lblPlayerName.Text = "Player Name"
        '
        'lblCharName
        '
        Me.lblCharName.AutoSize = True
        Me.lblCharName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharName.Location = New System.Drawing.Point(17, 66)
        Me.lblCharName.Name = "lblCharName"
        Me.lblCharName.Size = New System.Drawing.Size(98, 13)
        Me.lblCharName.TabIndex = 231
        Me.lblCharName.Text = "Character Name"
        '
        'lblCharRace
        '
        Me.lblCharRace.AutoSize = True
        Me.lblCharRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharRace.Location = New System.Drawing.Point(17, 118)
        Me.lblCharRace.Name = "lblCharRace"
        Me.lblCharRace.Size = New System.Drawing.Size(37, 13)
        Me.lblCharRace.TabIndex = 232
        Me.lblCharRace.Text = "Race"
        '
        'lblBlankets
        '
        Me.lblBlankets.AutoSize = True
        Me.lblBlankets.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlankets.Location = New System.Drawing.Point(11, 231)
        Me.lblBlankets.Name = "lblBlankets"
        Me.lblBlankets.Size = New System.Drawing.Size(56, 13)
        Me.lblBlankets.TabIndex = 234
        Me.lblBlankets.Text = "Blankets"
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(80, 231)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(23, 13)
        Me.lblCP.TabIndex = 235
        Me.lblCP.Text = "CP"
        '
        'lblSpentCP
        '
        Me.lblSpentCP.AutoSize = True
        Me.lblSpentCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpentCP.Location = New System.Drawing.Point(123, 231)
        Me.lblSpentCP.Name = "lblSpentCP"
        Me.lblSpentCP.Size = New System.Drawing.Size(40, 13)
        Me.lblSpentCP.TabIndex = 236
        Me.lblSpentCP.Text = "Spent"
        '
        'lblFreeCP
        '
        Me.lblFreeCP.AutoSize = True
        Me.lblFreeCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreeCP.Location = New System.Drawing.Point(175, 232)
        Me.lblFreeCP.Name = "lblFreeCP"
        Me.lblFreeCP.Size = New System.Drawing.Size(32, 13)
        Me.lblFreeCP.TabIndex = 237
        Me.lblFreeCP.Text = "Free"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(18, 270)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(38, 13)
        Me.lblLevel.TabIndex = 238
        Me.lblLevel.Text = "Level"
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHP.Location = New System.Drawing.Point(79, 270)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(24, 13)
        Me.lblHP.TabIndex = 239
        Me.lblHP.Text = "HP"
        '
        'lblSkillBreakdown
        '
        Me.lblSkillBreakdown.AutoSize = True
        Me.lblSkillBreakdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkillBreakdown.Location = New System.Drawing.Point(18, 314)
        Me.lblSkillBreakdown.Name = "lblSkillBreakdown"
        Me.lblSkillBreakdown.Size = New System.Drawing.Size(37, 13)
        Me.lblSkillBreakdown.TabIndex = 240
        Me.lblSkillBreakdown.Text = "Skills"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(725, 496)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 39)
        Me.btnReset.TabIndex = 251
        Me.btnReset.TabStop = False
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSaveAsText
        '
        Me.btnSaveAsText.Location = New System.Drawing.Point(573, 496)
        Me.btnSaveAsText.Name = "btnSaveAsText"
        Me.btnSaveAsText.Size = New System.Drawing.Size(100, 39)
        Me.btnSaveAsText.TabIndex = 253
        Me.btnSaveAsText.TabStop = False
        Me.btnSaveAsText.Text = "Save as Text"
        Me.btnSaveAsText.UseVisualStyleBackColor = True
        '
        'InBox
        '
        Me.InBox.FormattingEnabled = True
        Me.InBox.Location = New System.Drawing.Point(757, 313)
        Me.InBox.Name = "InBox"
        Me.InBox.Size = New System.Drawing.Size(119, 43)
        Me.InBox.TabIndex = 255
        '
        'btnSaveToFile
        '
        Me.btnSaveToFile.Location = New System.Drawing.Point(303, 496)
        Me.btnSaveToFile.Name = "btnSaveToFile"
        Me.btnSaveToFile.Size = New System.Drawing.Size(100, 39)
        Me.btnSaveToFile.TabIndex = 256
        Me.btnSaveToFile.TabStop = False
        Me.btnSaveToFile.Text = "Save to File"
        Me.btnSaveToFile.UseVisualStyleBackColor = True
        '
        'ddlFragGuild
        '
        Me.ddlFragGuild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlFragGuild.FormattingEnabled = True
        Me.ddlFragGuild.Items.AddRange(New Object() {"Jericho", "Kalidor", "Ralinwood"})
        Me.ddlFragGuild.Location = New System.Drawing.Point(163, 106)
        Me.ddlFragGuild.Name = "ddlFragGuild"
        Me.ddlFragGuild.Size = New System.Drawing.Size(56, 21)
        Me.ddlFragGuild.TabIndex = 270
        Me.ddlFragGuild.Visible = False
        '
        'Rogue
        '
        Me.Rogue.Controls.Add(Me.lblExecute)
        Me.Rogue.Controls.Add(Me.skillGarrote)
        Me.Rogue.Controls.Add(Me.lblGarrote)
        Me.Rogue.Controls.Add(Me.costGarrote)
        Me.Rogue.Controls.Add(Me.skillLocksmith)
        Me.Rogue.Controls.Add(Me.lblLocksmith)
        Me.Rogue.Controls.Add(Me.costLocksmith)
        Me.Rogue.Controls.Add(Me.skillSap)
        Me.Rogue.Controls.Add(Me.lblSap)
        Me.Rogue.Controls.Add(Me.costSap)
        Me.Rogue.Controls.Add(Me.skillDodge)
        Me.Rogue.Controls.Add(Me.lblDodge)
        Me.Rogue.Controls.Add(Me.costDodge)
        Me.Rogue.Controls.Add(Me.skillCritSpecific)
        Me.Rogue.Controls.Add(Me.lblCritSpecific)
        Me.Rogue.Controls.Add(Me.costCritSpecific)
        Me.Rogue.Controls.Add(Me.ddlCritSpecificWeapon)
        Me.Rogue.Controls.Add(Me.skillCritGroup)
        Me.Rogue.Controls.Add(Me.lblCritGroup)
        Me.Rogue.Controls.Add(Me.costCritGroup)
        Me.Rogue.Controls.Add(Me.ddlCritGroup)
        Me.Rogue.Controls.Add(Me.skillVitalBlow)
        Me.Rogue.Controls.Add(Me.lblVitalBlow)
        Me.Rogue.Controls.Add(Me.costVitalBlow)
        Me.Rogue.Controls.Add(Me.skillExecute)
        Me.Rogue.Controls.Add(Me.costExecute)
        Me.Rogue.Controls.Add(Me.ddlExecute)
        Me.Rogue.Controls.Add(Me.skillExecuteMaster)
        Me.Rogue.Controls.Add(Me.lblExecuteMaster)
        Me.Rogue.Controls.Add(Me.costExecuteMaster)
        Me.Rogue.Controls.Add(Me.ddlExecuteMaster)
        Me.Rogue.Location = New System.Drawing.Point(4, 25)
        Me.Rogue.Name = "Rogue"
        Me.Rogue.Size = New System.Drawing.Size(668, 451)
        Me.Rogue.TabIndex = 3
        Me.Rogue.Text = "                   Rogue                   "
        Me.Rogue.UseVisualStyleBackColor = True
        '
        'lblExecute
        '
        Me.lblExecute.AutoSize = True
        Me.lblExecute.Location = New System.Drawing.Point(29, 208)
        Me.lblExecute.Name = "lblExecute"
        Me.lblExecute.Size = New System.Drawing.Size(46, 13)
        Me.lblExecute.TabIndex = 198
        Me.lblExecute.Text = "Execute"
        '
        'skillGarrote
        '
        Me.skillGarrote.Location = New System.Drawing.Point(144, 26)
        Me.skillGarrote.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillGarrote.Name = "skillGarrote"
        Me.skillGarrote.ReadOnly = True
        Me.skillGarrote.Size = New System.Drawing.Size(33, 20)
        Me.skillGarrote.TabIndex = 162
        Me.skillGarrote.TabStop = False
        '
        'lblGarrote
        '
        Me.lblGarrote.AutoSize = True
        Me.lblGarrote.Location = New System.Drawing.Point(29, 28)
        Me.lblGarrote.Name = "lblGarrote"
        Me.lblGarrote.Size = New System.Drawing.Size(42, 13)
        Me.lblGarrote.TabIndex = 163
        Me.lblGarrote.Text = "Garrote"
        '
        'costGarrote
        '
        Me.costGarrote.AutoSize = True
        Me.costGarrote.Location = New System.Drawing.Point(119, 28)
        Me.costGarrote.Name = "costGarrote"
        Me.costGarrote.Size = New System.Drawing.Size(13, 13)
        Me.costGarrote.TabIndex = 164
        Me.costGarrote.Text = "0"
        '
        'skillLocksmith
        '
        Me.skillLocksmith.Location = New System.Drawing.Point(298, 26)
        Me.skillLocksmith.Name = "skillLocksmith"
        Me.skillLocksmith.ReadOnly = True
        Me.skillLocksmith.Size = New System.Drawing.Size(33, 20)
        Me.skillLocksmith.TabIndex = 165
        Me.skillLocksmith.TabStop = False
        '
        'lblLocksmith
        '
        Me.lblLocksmith.AutoSize = True
        Me.lblLocksmith.Location = New System.Drawing.Point(183, 29)
        Me.lblLocksmith.Name = "lblLocksmith"
        Me.lblLocksmith.Size = New System.Drawing.Size(55, 13)
        Me.lblLocksmith.TabIndex = 166
        Me.lblLocksmith.Text = "Locksmith"
        '
        'costLocksmith
        '
        Me.costLocksmith.AutoSize = True
        Me.costLocksmith.Location = New System.Drawing.Point(273, 29)
        Me.costLocksmith.Name = "costLocksmith"
        Me.costLocksmith.Size = New System.Drawing.Size(13, 13)
        Me.costLocksmith.TabIndex = 167
        Me.costLocksmith.Text = "0"
        '
        'skillSap
        '
        Me.skillSap.Location = New System.Drawing.Point(452, 26)
        Me.skillSap.Name = "skillSap"
        Me.skillSap.ReadOnly = True
        Me.skillSap.Size = New System.Drawing.Size(33, 20)
        Me.skillSap.TabIndex = 168
        Me.skillSap.TabStop = False
        '
        'lblSap
        '
        Me.lblSap.AutoSize = True
        Me.lblSap.Location = New System.Drawing.Point(337, 29)
        Me.lblSap.Name = "lblSap"
        Me.lblSap.Size = New System.Drawing.Size(26, 13)
        Me.lblSap.TabIndex = 169
        Me.lblSap.Text = "Sap"
        '
        'costSap
        '
        Me.costSap.AutoSize = True
        Me.costSap.Location = New System.Drawing.Point(427, 29)
        Me.costSap.Name = "costSap"
        Me.costSap.Size = New System.Drawing.Size(13, 13)
        Me.costSap.TabIndex = 170
        Me.costSap.Text = "0"
        '
        'skillDodge
        '
        Me.skillDodge.Location = New System.Drawing.Point(452, 101)
        Me.skillDodge.Name = "skillDodge"
        Me.skillDodge.ReadOnly = True
        Me.skillDodge.Size = New System.Drawing.Size(33, 20)
        Me.skillDodge.TabIndex = 171
        Me.skillDodge.TabStop = False
        '
        'lblDodge
        '
        Me.lblDodge.AutoSize = True
        Me.lblDodge.Location = New System.Drawing.Point(337, 103)
        Me.lblDodge.Name = "lblDodge"
        Me.lblDodge.Size = New System.Drawing.Size(39, 13)
        Me.lblDodge.TabIndex = 172
        Me.lblDodge.Text = "Dodge"
        '
        'costDodge
        '
        Me.costDodge.AutoSize = True
        Me.costDodge.Location = New System.Drawing.Point(427, 103)
        Me.costDodge.Name = "costDodge"
        Me.costDodge.Size = New System.Drawing.Size(13, 13)
        Me.costDodge.TabIndex = 173
        Me.costDodge.Text = "0"
        '
        'skillCritSpecific
        '
        Me.skillCritSpecific.Location = New System.Drawing.Point(144, 99)
        Me.skillCritSpecific.Name = "skillCritSpecific"
        Me.skillCritSpecific.ReadOnly = True
        Me.skillCritSpecific.Size = New System.Drawing.Size(33, 20)
        Me.skillCritSpecific.TabIndex = 183
        Me.skillCritSpecific.TabStop = False
        '
        'lblCritSpecific
        '
        Me.lblCritSpecific.AutoSize = True
        Me.lblCritSpecific.Location = New System.Drawing.Point(29, 102)
        Me.lblCritSpecific.Name = "lblCritSpecific"
        Me.lblCritSpecific.Size = New System.Drawing.Size(81, 13)
        Me.lblCritSpecific.TabIndex = 184
        Me.lblCritSpecific.Text = "Critical +2 Spec"
        '
        'costCritSpecific
        '
        Me.costCritSpecific.AutoSize = True
        Me.costCritSpecific.Location = New System.Drawing.Point(119, 102)
        Me.costCritSpecific.Name = "costCritSpecific"
        Me.costCritSpecific.Size = New System.Drawing.Size(13, 13)
        Me.costCritSpecific.TabIndex = 185
        Me.costCritSpecific.Text = "0"
        '
        'ddlCritSpecificWeapon
        '
        Me.ddlCritSpecificWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlCritSpecificWeapon.FormattingEnabled = True
        Me.ddlCritSpecificWeapon.Location = New System.Drawing.Point(32, 125)
        Me.ddlCritSpecificWeapon.Name = "ddlCritSpecificWeapon"
        Me.ddlCritSpecificWeapon.Size = New System.Drawing.Size(145, 21)
        Me.ddlCritSpecificWeapon.TabIndex = 186
        Me.ddlCritSpecificWeapon.TabStop = False
        '
        'skillCritGroup
        '
        Me.skillCritGroup.Location = New System.Drawing.Point(299, 100)
        Me.skillCritGroup.Name = "skillCritGroup"
        Me.skillCritGroup.ReadOnly = True
        Me.skillCritGroup.Size = New System.Drawing.Size(33, 20)
        Me.skillCritGroup.TabIndex = 187
        Me.skillCritGroup.TabStop = False
        '
        'lblCritGroup
        '
        Me.lblCritGroup.AutoSize = True
        Me.lblCritGroup.Location = New System.Drawing.Point(184, 103)
        Me.lblCritGroup.Name = "lblCritGroup"
        Me.lblCritGroup.Size = New System.Drawing.Size(69, 13)
        Me.lblCritGroup.TabIndex = 188
        Me.lblCritGroup.Text = "Crit +2 Group"
        '
        'costCritGroup
        '
        Me.costCritGroup.AutoSize = True
        Me.costCritGroup.Location = New System.Drawing.Point(274, 103)
        Me.costCritGroup.Name = "costCritGroup"
        Me.costCritGroup.Size = New System.Drawing.Size(13, 13)
        Me.costCritGroup.TabIndex = 189
        Me.costCritGroup.Text = "0"
        '
        'ddlCritGroup
        '
        Me.ddlCritGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlCritGroup.FormattingEnabled = True
        Me.ddlCritGroup.Location = New System.Drawing.Point(187, 126)
        Me.ddlCritGroup.Name = "ddlCritGroup"
        Me.ddlCritGroup.Size = New System.Drawing.Size(145, 21)
        Me.ddlCritGroup.TabIndex = 190
        Me.ddlCritGroup.TabStop = False
        '
        'skillVitalBlow
        '
        Me.skillVitalBlow.Location = New System.Drawing.Point(606, 27)
        Me.skillVitalBlow.Name = "skillVitalBlow"
        Me.skillVitalBlow.ReadOnly = True
        Me.skillVitalBlow.Size = New System.Drawing.Size(33, 20)
        Me.skillVitalBlow.TabIndex = 191
        Me.skillVitalBlow.TabStop = False
        '
        'lblVitalBlow
        '
        Me.lblVitalBlow.AutoSize = True
        Me.lblVitalBlow.Location = New System.Drawing.Point(491, 30)
        Me.lblVitalBlow.Name = "lblVitalBlow"
        Me.lblVitalBlow.Size = New System.Drawing.Size(53, 13)
        Me.lblVitalBlow.TabIndex = 192
        Me.lblVitalBlow.Text = "Vital Blow"
        '
        'costVitalBlow
        '
        Me.costVitalBlow.AutoSize = True
        Me.costVitalBlow.Location = New System.Drawing.Point(581, 30)
        Me.costVitalBlow.Name = "costVitalBlow"
        Me.costVitalBlow.Size = New System.Drawing.Size(13, 13)
        Me.costVitalBlow.TabIndex = 193
        Me.costVitalBlow.Text = "0"
        '
        'skillExecute
        '
        Me.skillExecute.Location = New System.Drawing.Point(144, 205)
        Me.skillExecute.Name = "skillExecute"
        Me.skillExecute.ReadOnly = True
        Me.skillExecute.Size = New System.Drawing.Size(33, 20)
        Me.skillExecute.TabIndex = 197
        Me.skillExecute.TabStop = False
        '
        'costExecute
        '
        Me.costExecute.AutoSize = True
        Me.costExecute.Location = New System.Drawing.Point(119, 208)
        Me.costExecute.Name = "costExecute"
        Me.costExecute.Size = New System.Drawing.Size(13, 13)
        Me.costExecute.TabIndex = 199
        Me.costExecute.Text = "0"
        '
        'ddlExecute
        '
        Me.ddlExecute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlExecute.FormattingEnabled = True
        Me.ddlExecute.Location = New System.Drawing.Point(32, 231)
        Me.ddlExecute.Name = "ddlExecute"
        Me.ddlExecute.Size = New System.Drawing.Size(145, 21)
        Me.ddlExecute.TabIndex = 200
        Me.ddlExecute.TabStop = False
        '
        'skillExecuteMaster
        '
        Me.skillExecuteMaster.Location = New System.Drawing.Point(298, 206)
        Me.skillExecuteMaster.Name = "skillExecuteMaster"
        Me.skillExecuteMaster.ReadOnly = True
        Me.skillExecuteMaster.Size = New System.Drawing.Size(33, 20)
        Me.skillExecuteMaster.TabIndex = 201
        Me.skillExecuteMaster.TabStop = False
        '
        'lblExecuteMaster
        '
        Me.lblExecuteMaster.AutoSize = True
        Me.lblExecuteMaster.Location = New System.Drawing.Point(183, 209)
        Me.lblExecuteMaster.Name = "lblExecuteMaster"
        Me.lblExecuteMaster.Size = New System.Drawing.Size(84, 13)
        Me.lblExecuteMaster.TabIndex = 202
        Me.lblExecuteMaster.Text = "Execute: Master"
        '
        'costExecuteMaster
        '
        Me.costExecuteMaster.AutoSize = True
        Me.costExecuteMaster.Location = New System.Drawing.Point(273, 209)
        Me.costExecuteMaster.Name = "costExecuteMaster"
        Me.costExecuteMaster.Size = New System.Drawing.Size(13, 13)
        Me.costExecuteMaster.TabIndex = 203
        Me.costExecuteMaster.Text = "0"
        '
        'ddlExecuteMaster
        '
        Me.ddlExecuteMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlExecuteMaster.FormattingEnabled = True
        Me.ddlExecuteMaster.Location = New System.Drawing.Point(186, 232)
        Me.ddlExecuteMaster.Name = "ddlExecuteMaster"
        Me.ddlExecuteMaster.Size = New System.Drawing.Size(145, 21)
        Me.ddlExecuteMaster.TabIndex = 204
        Me.ddlExecuteMaster.TabStop = False
        '
        'Warrior
        '
        Me.Warrior.Controls.Add(Me.skillSimpleProf)
        Me.Warrior.Controls.Add(Me.lblSimpleProf)
        Me.Warrior.Controls.Add(Me.costSimpleProf)
        Me.Warrior.Controls.Add(Me.lblSlayParry)
        Me.Warrior.Controls.Add(Me.lblAmbidexterity)
        Me.Warrior.Controls.Add(Me.skillFlorentine)
        Me.Warrior.Controls.Add(Me.lblFlorentine)
        Me.Warrior.Controls.Add(Me.costFlorentine)
        Me.Warrior.Controls.Add(Me.skillFlurryOfBlows)
        Me.Warrior.Controls.Add(Me.lblFlurryofBlows)
        Me.Warrior.Controls.Add(Me.costFlurryOfBlows)
        Me.Warrior.Controls.Add(Me.skillHeavyArmour)
        Me.Warrior.Controls.Add(Me.lblHeavyArmour)
        Me.Warrior.Controls.Add(Me.costHeavyArmour)
        Me.Warrior.Controls.Add(Me.skillSelfMut)
        Me.Warrior.Controls.Add(Me.lblSelfMut)
        Me.Warrior.Controls.Add(Me.costSelfMut)
        Me.Warrior.Controls.Add(Me.skillShield)
        Me.Warrior.Controls.Add(Me.lblShield)
        Me.Warrior.Controls.Add(Me.costShield)
        Me.Warrior.Controls.Add(Me.skillMedProf)
        Me.Warrior.Controls.Add(Me.lblMedProf)
        Me.Warrior.Controls.Add(Me.costMedProf)
        Me.Warrior.Controls.Add(Me.skillLargeProf)
        Me.Warrior.Controls.Add(Me.lblLargeProf)
        Me.Warrior.Controls.Add(Me.costLargeProf)
        Me.Warrior.Controls.Add(Me.skillSpecGroup)
        Me.Warrior.Controls.Add(Me.lblSpecGroup)
        Me.Warrior.Controls.Add(Me.costSpecGroup)
        Me.Warrior.Controls.Add(Me.skillSpecSpecific)
        Me.Warrior.Controls.Add(Me.lblSpecSpecific)
        Me.Warrior.Controls.Add(Me.costSpecSpecific)
        Me.Warrior.Controls.Add(Me.skillExoticProf)
        Me.Warrior.Controls.Add(Me.lblExoticProf)
        Me.Warrior.Controls.Add(Me.costExoticProf)
        Me.Warrior.Controls.Add(Me.ddlExoticWeapon)
        Me.Warrior.Controls.Add(Me.ddlSpecGroup)
        Me.Warrior.Controls.Add(Me.ddlSpecSpecific)
        Me.Warrior.Controls.Add(Me.skillSlayParry)
        Me.Warrior.Controls.Add(Me.costSlayParry)
        Me.Warrior.Controls.Add(Me.ddlSlayParryWeapon)
        Me.Warrior.Controls.Add(Me.skillSlayParryMaster)
        Me.Warrior.Controls.Add(Me.lblSlayParryMaster)
        Me.Warrior.Controls.Add(Me.costSlayParryMaster)
        Me.Warrior.Controls.Add(Me.ddlSlayParryMasterWeapon)
        Me.Warrior.Controls.Add(Me.costAmbidexterity)
        Me.Warrior.Controls.Add(Me.skillAmbidexterity)
        Me.Warrior.Controls.Add(Me.skillWeaponRefocus)
        Me.Warrior.Controls.Add(Me.lblWeaponRefocus)
        Me.Warrior.Controls.Add(Me.costWeaponRefocus)
        Me.Warrior.Location = New System.Drawing.Point(4, 25)
        Me.Warrior.Name = "Warrior"
        Me.Warrior.Size = New System.Drawing.Size(668, 451)
        Me.Warrior.TabIndex = 2
        Me.Warrior.Text = "                  Warrior                  "
        Me.Warrior.UseVisualStyleBackColor = True
        '
        'skillSimpleProf
        '
        Me.skillSimpleProf.Location = New System.Drawing.Point(606, 166)
        Me.skillSimpleProf.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSimpleProf.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSimpleProf.Name = "skillSimpleProf"
        Me.skillSimpleProf.ReadOnly = True
        Me.skillSimpleProf.Size = New System.Drawing.Size(33, 20)
        Me.skillSimpleProf.TabIndex = 148
        Me.skillSimpleProf.TabStop = False
        Me.skillSimpleProf.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSimpleProf.Visible = False
        '
        'lblSimpleProf
        '
        Me.lblSimpleProf.AutoSize = True
        Me.lblSimpleProf.Location = New System.Drawing.Point(491, 169)
        Me.lblSimpleProf.Name = "lblSimpleProf"
        Me.lblSimpleProf.Size = New System.Drawing.Size(95, 13)
        Me.lblSimpleProf.TabIndex = 148
        Me.lblSimpleProf.Text = "Group Prof. Simple"
        Me.lblSimpleProf.Visible = False
        '
        'costSimpleProf
        '
        Me.costSimpleProf.AutoSize = True
        Me.costSimpleProf.Location = New System.Drawing.Point(584, 169)
        Me.costSimpleProf.Name = "costSimpleProf"
        Me.costSimpleProf.Size = New System.Drawing.Size(13, 13)
        Me.costSimpleProf.TabIndex = 149
        Me.costSimpleProf.Text = "0"
        Me.costSimpleProf.Visible = False
        '
        'lblSlayParry
        '
        Me.lblSlayParry.AutoSize = True
        Me.lblSlayParry.Location = New System.Drawing.Point(338, 252)
        Me.lblSlayParry.Name = "lblSlayParry"
        Me.lblSlayParry.Size = New System.Drawing.Size(56, 13)
        Me.lblSlayParry.TabIndex = 141
        Me.lblSlayParry.Text = "Slay/Parry"
        '
        'lblAmbidexterity
        '
        Me.lblAmbidexterity.AutoSize = True
        Me.lblAmbidexterity.Location = New System.Drawing.Point(29, 28)
        Me.lblAmbidexterity.Name = "lblAmbidexterity"
        Me.lblAmbidexterity.Size = New System.Drawing.Size(69, 13)
        Me.lblAmbidexterity.TabIndex = 96
        Me.lblAmbidexterity.Text = "Ambidexterity"
        '
        'skillFlorentine
        '
        Me.skillFlorentine.Location = New System.Drawing.Point(298, 26)
        Me.skillFlorentine.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillFlorentine.Name = "skillFlorentine"
        Me.skillFlorentine.ReadOnly = True
        Me.skillFlorentine.Size = New System.Drawing.Size(33, 20)
        Me.skillFlorentine.TabIndex = 98
        Me.skillFlorentine.TabStop = False
        '
        'lblFlorentine
        '
        Me.lblFlorentine.AutoSize = True
        Me.lblFlorentine.Location = New System.Drawing.Point(183, 29)
        Me.lblFlorentine.Name = "lblFlorentine"
        Me.lblFlorentine.Size = New System.Drawing.Size(53, 13)
        Me.lblFlorentine.TabIndex = 99
        Me.lblFlorentine.Text = "Florentine"
        '
        'costFlorentine
        '
        Me.costFlorentine.AutoSize = True
        Me.costFlorentine.Location = New System.Drawing.Point(273, 29)
        Me.costFlorentine.Name = "costFlorentine"
        Me.costFlorentine.Size = New System.Drawing.Size(13, 13)
        Me.costFlorentine.TabIndex = 100
        Me.costFlorentine.Text = "0"
        '
        'skillFlurryOfBlows
        '
        Me.skillFlurryOfBlows.Location = New System.Drawing.Point(452, 27)
        Me.skillFlurryOfBlows.Name = "skillFlurryOfBlows"
        Me.skillFlurryOfBlows.ReadOnly = True
        Me.skillFlurryOfBlows.Size = New System.Drawing.Size(33, 20)
        Me.skillFlurryOfBlows.TabIndex = 101
        Me.skillFlurryOfBlows.TabStop = False
        '
        'lblFlurryofBlows
        '
        Me.lblFlurryofBlows.AutoSize = True
        Me.lblFlurryofBlows.Location = New System.Drawing.Point(337, 30)
        Me.lblFlurryofBlows.Name = "lblFlurryofBlows"
        Me.lblFlurryofBlows.Size = New System.Drawing.Size(75, 13)
        Me.lblFlurryofBlows.TabIndex = 102
        Me.lblFlurryofBlows.Text = "Flurry of Blows"
        '
        'costFlurryOfBlows
        '
        Me.costFlurryOfBlows.AutoSize = True
        Me.costFlurryOfBlows.Location = New System.Drawing.Point(431, 30)
        Me.costFlurryOfBlows.Name = "costFlurryOfBlows"
        Me.costFlurryOfBlows.Size = New System.Drawing.Size(13, 13)
        Me.costFlurryOfBlows.TabIndex = 103
        Me.costFlurryOfBlows.Text = "0"
        '
        'skillHeavyArmour
        '
        Me.skillHeavyArmour.Location = New System.Drawing.Point(606, 27)
        Me.skillHeavyArmour.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillHeavyArmour.Name = "skillHeavyArmour"
        Me.skillHeavyArmour.ReadOnly = True
        Me.skillHeavyArmour.Size = New System.Drawing.Size(33, 20)
        Me.skillHeavyArmour.TabIndex = 104
        Me.skillHeavyArmour.TabStop = False
        '
        'lblHeavyArmour
        '
        Me.lblHeavyArmour.AutoSize = True
        Me.lblHeavyArmour.Location = New System.Drawing.Point(491, 29)
        Me.lblHeavyArmour.Name = "lblHeavyArmour"
        Me.lblHeavyArmour.Size = New System.Drawing.Size(74, 13)
        Me.lblHeavyArmour.TabIndex = 105
        Me.lblHeavyArmour.Text = "Heavy Armour"
        '
        'costHeavyArmour
        '
        Me.costHeavyArmour.AutoSize = True
        Me.costHeavyArmour.Location = New System.Drawing.Point(581, 29)
        Me.costHeavyArmour.Name = "costHeavyArmour"
        Me.costHeavyArmour.Size = New System.Drawing.Size(13, 13)
        Me.costHeavyArmour.TabIndex = 106
        Me.costHeavyArmour.Text = "0"
        '
        'skillSelfMut
        '
        Me.skillSelfMut.Location = New System.Drawing.Point(144, 93)
        Me.skillSelfMut.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSelfMut.Name = "skillSelfMut"
        Me.skillSelfMut.ReadOnly = True
        Me.skillSelfMut.Size = New System.Drawing.Size(33, 20)
        Me.skillSelfMut.TabIndex = 107
        Me.skillSelfMut.TabStop = False
        '
        'lblSelfMut
        '
        Me.lblSelfMut.AutoSize = True
        Me.lblSelfMut.Location = New System.Drawing.Point(29, 95)
        Me.lblSelfMut.Name = "lblSelfMut"
        Me.lblSelfMut.Size = New System.Drawing.Size(65, 13)
        Me.lblSelfMut.TabIndex = 108
        Me.lblSelfMut.Text = "Self Mutilate"
        '
        'costSelfMut
        '
        Me.costSelfMut.AutoSize = True
        Me.costSelfMut.Location = New System.Drawing.Point(119, 95)
        Me.costSelfMut.Name = "costSelfMut"
        Me.costSelfMut.Size = New System.Drawing.Size(19, 13)
        Me.costSelfMut.TabIndex = 109
        Me.costSelfMut.Text = "15"
        '
        'skillShield
        '
        Me.skillShield.Location = New System.Drawing.Point(298, 93)
        Me.skillShield.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillShield.Name = "skillShield"
        Me.skillShield.ReadOnly = True
        Me.skillShield.Size = New System.Drawing.Size(33, 20)
        Me.skillShield.TabIndex = 110
        Me.skillShield.TabStop = False
        '
        'lblShield
        '
        Me.lblShield.AutoSize = True
        Me.lblShield.Location = New System.Drawing.Point(183, 95)
        Me.lblShield.Name = "lblShield"
        Me.lblShield.Size = New System.Drawing.Size(36, 13)
        Me.lblShield.TabIndex = 111
        Me.lblShield.Text = "Shield"
        '
        'costShield
        '
        Me.costShield.AutoSize = True
        Me.costShield.Location = New System.Drawing.Point(273, 95)
        Me.costShield.Name = "costShield"
        Me.costShield.Size = New System.Drawing.Size(13, 13)
        Me.costShield.TabIndex = 112
        Me.costShield.Text = "0"
        '
        'skillMedProf
        '
        Me.skillMedProf.Location = New System.Drawing.Point(144, 166)
        Me.skillMedProf.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillMedProf.Name = "skillMedProf"
        Me.skillMedProf.ReadOnly = True
        Me.skillMedProf.Size = New System.Drawing.Size(33, 20)
        Me.skillMedProf.TabIndex = 113
        Me.skillMedProf.TabStop = False
        '
        'lblMedProf
        '
        Me.lblMedProf.AutoSize = True
        Me.lblMedProf.Location = New System.Drawing.Point(29, 169)
        Me.lblMedProf.Name = "lblMedProf"
        Me.lblMedProf.Size = New System.Drawing.Size(85, 13)
        Me.lblMedProf.TabIndex = 114
        Me.lblMedProf.Text = "Group Prof. Med"
        '
        'costMedProf
        '
        Me.costMedProf.AutoSize = True
        Me.costMedProf.Location = New System.Drawing.Point(119, 169)
        Me.costMedProf.Name = "costMedProf"
        Me.costMedProf.Size = New System.Drawing.Size(13, 13)
        Me.costMedProf.TabIndex = 115
        Me.costMedProf.Text = "0"
        '
        'skillLargeProf
        '
        Me.skillLargeProf.Location = New System.Drawing.Point(298, 166)
        Me.skillLargeProf.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillLargeProf.Name = "skillLargeProf"
        Me.skillLargeProf.ReadOnly = True
        Me.skillLargeProf.Size = New System.Drawing.Size(33, 20)
        Me.skillLargeProf.TabIndex = 116
        Me.skillLargeProf.TabStop = False
        '
        'lblLargeProf
        '
        Me.lblLargeProf.AutoSize = True
        Me.lblLargeProf.Location = New System.Drawing.Point(183, 169)
        Me.lblLargeProf.Name = "lblLargeProf"
        Me.lblLargeProf.Size = New System.Drawing.Size(79, 13)
        Me.lblLargeProf.TabIndex = 117
        Me.lblLargeProf.Text = "Group Prof. Lrg"
        '
        'costLargeProf
        '
        Me.costLargeProf.AutoSize = True
        Me.costLargeProf.Location = New System.Drawing.Point(273, 169)
        Me.costLargeProf.Name = "costLargeProf"
        Me.costLargeProf.Size = New System.Drawing.Size(13, 13)
        Me.costLargeProf.TabIndex = 118
        Me.costLargeProf.Text = "0"
        '
        'skillSpecGroup
        '
        Me.skillSpecGroup.Location = New System.Drawing.Point(144, 250)
        Me.skillSpecGroup.Name = "skillSpecGroup"
        Me.skillSpecGroup.ReadOnly = True
        Me.skillSpecGroup.Size = New System.Drawing.Size(33, 20)
        Me.skillSpecGroup.TabIndex = 119
        Me.skillSpecGroup.TabStop = False
        '
        'lblSpecGroup
        '
        Me.lblSpecGroup.AutoSize = True
        Me.lblSpecGroup.Location = New System.Drawing.Point(29, 252)
        Me.lblSpecGroup.Name = "lblSpecGroup"
        Me.lblSpecGroup.Size = New System.Drawing.Size(79, 13)
        Me.lblSpecGroup.TabIndex = 120
        Me.lblSpecGroup.Text = "Spec +1 Group"
        '
        'costSpecGroup
        '
        Me.costSpecGroup.AutoSize = True
        Me.costSpecGroup.Location = New System.Drawing.Point(119, 252)
        Me.costSpecGroup.Name = "costSpecGroup"
        Me.costSpecGroup.Size = New System.Drawing.Size(13, 13)
        Me.costSpecGroup.TabIndex = 121
        Me.costSpecGroup.Text = "0"
        '
        'skillSpecSpecific
        '
        Me.skillSpecSpecific.Location = New System.Drawing.Point(298, 250)
        Me.skillSpecSpecific.Name = "skillSpecSpecific"
        Me.skillSpecSpecific.ReadOnly = True
        Me.skillSpecSpecific.Size = New System.Drawing.Size(33, 20)
        Me.skillSpecSpecific.TabIndex = 122
        Me.skillSpecSpecific.TabStop = False
        '
        'lblSpecSpecific
        '
        Me.lblSpecSpecific.AutoSize = True
        Me.lblSpecSpecific.Location = New System.Drawing.Point(183, 253)
        Me.lblSpecSpecific.Name = "lblSpecSpecific"
        Me.lblSpecSpecific.Size = New System.Drawing.Size(88, 13)
        Me.lblSpecSpecific.TabIndex = 123
        Me.lblSpecSpecific.Text = "Spec +1 Specific"
        '
        'costSpecSpecific
        '
        Me.costSpecSpecific.AutoSize = True
        Me.costSpecSpecific.Location = New System.Drawing.Point(273, 253)
        Me.costSpecSpecific.Name = "costSpecSpecific"
        Me.costSpecSpecific.Size = New System.Drawing.Size(13, 13)
        Me.costSpecSpecific.TabIndex = 124
        Me.costSpecSpecific.Text = "0"
        '
        'skillExoticProf
        '
        Me.skillExoticProf.Location = New System.Drawing.Point(452, 168)
        Me.skillExoticProf.Name = "skillExoticProf"
        Me.skillExoticProf.ReadOnly = True
        Me.skillExoticProf.Size = New System.Drawing.Size(33, 20)
        Me.skillExoticProf.TabIndex = 134
        Me.skillExoticProf.TabStop = False
        '
        'lblExoticProf
        '
        Me.lblExoticProf.AutoSize = True
        Me.lblExoticProf.Location = New System.Drawing.Point(337, 170)
        Me.lblExoticProf.Name = "lblExoticProf"
        Me.lblExoticProf.Size = New System.Drawing.Size(61, 13)
        Me.lblExoticProf.TabIndex = 135
        Me.lblExoticProf.Text = "Prof. Exotic"
        '
        'costExoticProf
        '
        Me.costExoticProf.AutoSize = True
        Me.costExoticProf.Location = New System.Drawing.Point(427, 170)
        Me.costExoticProf.Name = "costExoticProf"
        Me.costExoticProf.Size = New System.Drawing.Size(13, 13)
        Me.costExoticProf.TabIndex = 136
        Me.costExoticProf.Text = "0"
        '
        'ddlExoticWeapon
        '
        Me.ddlExoticWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlExoticWeapon.FormattingEnabled = True
        Me.ddlExoticWeapon.Items.AddRange(New Object() {"Stilleto", "2H Spear/Trident", "2H Maul", "Bastard Sword"})
        Me.ddlExoticWeapon.Location = New System.Drawing.Point(340, 193)
        Me.ddlExoticWeapon.Name = "ddlExoticWeapon"
        Me.ddlExoticWeapon.Size = New System.Drawing.Size(145, 21)
        Me.ddlExoticWeapon.TabIndex = 137
        Me.ddlExoticWeapon.TabStop = False
        '
        'ddlSpecGroup
        '
        Me.ddlSpecGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSpecGroup.FormattingEnabled = True
        Me.ddlSpecGroup.Location = New System.Drawing.Point(32, 276)
        Me.ddlSpecGroup.Name = "ddlSpecGroup"
        Me.ddlSpecGroup.Size = New System.Drawing.Size(145, 21)
        Me.ddlSpecGroup.TabIndex = 138
        Me.ddlSpecGroup.TabStop = False
        '
        'ddlSpecSpecific
        '
        Me.ddlSpecSpecific.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSpecSpecific.FormattingEnabled = True
        Me.ddlSpecSpecific.Location = New System.Drawing.Point(186, 276)
        Me.ddlSpecSpecific.Name = "ddlSpecSpecific"
        Me.ddlSpecSpecific.Size = New System.Drawing.Size(145, 21)
        Me.ddlSpecSpecific.TabIndex = 139
        Me.ddlSpecSpecific.TabStop = False
        '
        'skillSlayParry
        '
        Me.skillSlayParry.Location = New System.Drawing.Point(453, 249)
        Me.skillSlayParry.Name = "skillSlayParry"
        Me.skillSlayParry.ReadOnly = True
        Me.skillSlayParry.Size = New System.Drawing.Size(33, 20)
        Me.skillSlayParry.TabIndex = 140
        Me.skillSlayParry.TabStop = False
        '
        'costSlayParry
        '
        Me.costSlayParry.AutoSize = True
        Me.costSlayParry.Location = New System.Drawing.Point(431, 252)
        Me.costSlayParry.Name = "costSlayParry"
        Me.costSlayParry.Size = New System.Drawing.Size(13, 13)
        Me.costSlayParry.TabIndex = 142
        Me.costSlayParry.Text = "0"
        '
        'ddlSlayParryWeapon
        '
        Me.ddlSlayParryWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSlayParryWeapon.FormattingEnabled = True
        Me.ddlSlayParryWeapon.Location = New System.Drawing.Point(341, 275)
        Me.ddlSlayParryWeapon.Name = "ddlSlayParryWeapon"
        Me.ddlSlayParryWeapon.Size = New System.Drawing.Size(145, 21)
        Me.ddlSlayParryWeapon.TabIndex = 143
        Me.ddlSlayParryWeapon.TabStop = False
        '
        'skillSlayParryMaster
        '
        Me.skillSlayParryMaster.Location = New System.Drawing.Point(607, 250)
        Me.skillSlayParryMaster.Name = "skillSlayParryMaster"
        Me.skillSlayParryMaster.ReadOnly = True
        Me.skillSlayParryMaster.Size = New System.Drawing.Size(33, 20)
        Me.skillSlayParryMaster.TabIndex = 144
        Me.skillSlayParryMaster.TabStop = False
        '
        'lblSlayParryMaster
        '
        Me.lblSlayParryMaster.AutoSize = True
        Me.lblSlayParryMaster.Location = New System.Drawing.Point(492, 253)
        Me.lblSlayParryMaster.Name = "lblSlayParryMaster"
        Me.lblSlayParryMaster.Size = New System.Drawing.Size(82, 13)
        Me.lblSlayParryMaster.TabIndex = 145
        Me.lblSlayParryMaster.Text = "Slay/Parry Mstr."
        '
        'costSlayParryMaster
        '
        Me.costSlayParryMaster.AutoSize = True
        Me.costSlayParryMaster.Location = New System.Drawing.Point(582, 253)
        Me.costSlayParryMaster.Name = "costSlayParryMaster"
        Me.costSlayParryMaster.Size = New System.Drawing.Size(13, 13)
        Me.costSlayParryMaster.TabIndex = 146
        Me.costSlayParryMaster.Text = "0"
        '
        'ddlSlayParryMasterWeapon
        '
        Me.ddlSlayParryMasterWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSlayParryMasterWeapon.FormattingEnabled = True
        Me.ddlSlayParryMasterWeapon.Location = New System.Drawing.Point(495, 276)
        Me.ddlSlayParryMasterWeapon.Name = "ddlSlayParryMasterWeapon"
        Me.ddlSlayParryMasterWeapon.Size = New System.Drawing.Size(145, 21)
        Me.ddlSlayParryMasterWeapon.TabIndex = 147
        Me.ddlSlayParryMasterWeapon.TabStop = False
        '
        'costAmbidexterity
        '
        Me.costAmbidexterity.AutoSize = True
        Me.costAmbidexterity.Location = New System.Drawing.Point(119, 28)
        Me.costAmbidexterity.Name = "costAmbidexterity"
        Me.costAmbidexterity.Size = New System.Drawing.Size(13, 13)
        Me.costAmbidexterity.TabIndex = 216
        Me.costAmbidexterity.Text = "0"
        '
        'skillAmbidexterity
        '
        Me.skillAmbidexterity.Location = New System.Drawing.Point(144, 26)
        Me.skillAmbidexterity.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillAmbidexterity.Name = "skillAmbidexterity"
        Me.skillAmbidexterity.ReadOnly = True
        Me.skillAmbidexterity.Size = New System.Drawing.Size(33, 20)
        Me.skillAmbidexterity.TabIndex = 215
        Me.skillAmbidexterity.TabStop = False
        '
        'skillWeaponRefocus
        '
        Me.skillWeaponRefocus.Location = New System.Drawing.Point(453, 93)
        Me.skillWeaponRefocus.Name = "skillWeaponRefocus"
        Me.skillWeaponRefocus.ReadOnly = True
        Me.skillWeaponRefocus.Size = New System.Drawing.Size(33, 20)
        Me.skillWeaponRefocus.TabIndex = 151
        Me.skillWeaponRefocus.TabStop = False
        '
        'lblWeaponRefocus
        '
        Me.lblWeaponRefocus.AutoSize = True
        Me.lblWeaponRefocus.Location = New System.Drawing.Point(338, 96)
        Me.lblWeaponRefocus.Name = "lblWeaponRefocus"
        Me.lblWeaponRefocus.Size = New System.Drawing.Size(91, 13)
        Me.lblWeaponRefocus.TabIndex = 152
        Me.lblWeaponRefocus.Text = "Weapon Refocus"
        '
        'costWeaponRefocus
        '
        Me.costWeaponRefocus.AutoSize = True
        Me.costWeaponRefocus.Location = New System.Drawing.Point(428, 96)
        Me.costWeaponRefocus.Name = "costWeaponRefocus"
        Me.costWeaponRefocus.Size = New System.Drawing.Size(13, 13)
        Me.costWeaponRefocus.TabIndex = 153
        Me.costWeaponRefocus.Text = "0"
        '
        'Scholar
        '
        Me.Scholar.Controls.Add(Me.lblPyramid)
        Me.Scholar.Controls.Add(Me.lblPyramidOrSpinners)
        Me.Scholar.Controls.Add(Me.ddlPyramid)
        Me.Scholar.Controls.Add(Me.costAdvRitual)
        Me.Scholar.Controls.Add(Me.lblAdvRitual)
        Me.Scholar.Controls.Add(Me.skillAdvRitual)
        Me.Scholar.Controls.Add(Me.Label31)
        Me.Scholar.Controls.Add(Me.lblSpellSlots)
        Me.Scholar.Controls.Add(Me.ddlEleAttunement4)
        Me.Scholar.Controls.Add(Me.ddlEleAttunement3)
        Me.Scholar.Controls.Add(Me.ddlEleAttunement2)
        Me.Scholar.Controls.Add(Me.ddlEleAttunement1)
        Me.Scholar.Controls.Add(Me.skillPhysician)
        Me.Scholar.Controls.Add(Me.skillAnatomy)
        Me.Scholar.Controls.Add(Me.lblAnatomy)
        Me.Scholar.Controls.Add(Me.costAnatomy)
        Me.Scholar.Controls.Add(Me.skillMysticism)
        Me.Scholar.Controls.Add(Me.lblMysticism)
        Me.Scholar.Controls.Add(Me.costMysticism)
        Me.Scholar.Controls.Add(Me.skillDemonAngelArts)
        Me.Scholar.Controls.Add(Me.lblDemonAngelArts)
        Me.Scholar.Controls.Add(Me.costDemonAngelArts)
        Me.Scholar.Controls.Add(Me.skillEleAttunement)
        Me.Scholar.Controls.Add(Me.lblEleAttunement)
        Me.Scholar.Controls.Add(Me.costEleAttunement)
        Me.Scholar.Controls.Add(Me.skillFirstAid)
        Me.Scholar.Controls.Add(Me.lblFirstAid)
        Me.Scholar.Controls.Add(Me.costFirstAid)
        Me.Scholar.Controls.Add(Me.skillNecroArts)
        Me.Scholar.Controls.Add(Me.lblNecroArts)
        Me.Scholar.Controls.Add(Me.costNecroArts)
        Me.Scholar.Controls.Add(Me.lblPhysician)
        Me.Scholar.Controls.Add(Me.costPhysician)
        Me.Scholar.Controls.Add(Me.skillReadAndWrite)
        Me.Scholar.Controls.Add(Me.lblReadAndWrite)
        Me.Scholar.Controls.Add(Me.costReadAndWrite)
        Me.Scholar.Controls.Add(Me.costSpellRitual)
        Me.Scholar.Controls.Add(Me.skillReadMagic)
        Me.Scholar.Controls.Add(Me.lblReadMagic)
        Me.Scholar.Controls.Add(Me.costReadMagic)
        Me.Scholar.Controls.Add(Me.skillReadMagicAvd)
        Me.Scholar.Controls.Add(Me.lblReadMagicAvd)
        Me.Scholar.Controls.Add(Me.costReadMagicAvd)
        Me.Scholar.Controls.Add(Me.lblRitual)
        Me.Scholar.Controls.Add(Me.skillReadMagicRitual)
        Me.Scholar.Controls.Add(Me.lblSpellLevel9)
        Me.Scholar.Controls.Add(Me.lblReadMagicRitual)
        Me.Scholar.Controls.Add(Me.lblSpellLevel8)
        Me.Scholar.Controls.Add(Me.costReadMagicRitual)
        Me.Scholar.Controls.Add(Me.lblSpellLevel7)
        Me.Scholar.Controls.Add(Me.skillSphere1)
        Me.Scholar.Controls.Add(Me.lblSpellLevel6)
        Me.Scholar.Controls.Add(Me.lblSphere1)
        Me.Scholar.Controls.Add(Me.lblSpellLevel5)
        Me.Scholar.Controls.Add(Me.costSphere1)
        Me.Scholar.Controls.Add(Me.lblSpellLevel4)
        Me.Scholar.Controls.Add(Me.skillSphere2)
        Me.Scholar.Controls.Add(Me.lblSpellLevel3)
        Me.Scholar.Controls.Add(Me.lblSphere2)
        Me.Scholar.Controls.Add(Me.lblSpellLevel2)
        Me.Scholar.Controls.Add(Me.costSphere2)
        Me.Scholar.Controls.Add(Me.lblSpellLevel1)
        Me.Scholar.Controls.Add(Me.skillSphere3)
        Me.Scholar.Controls.Add(Me.lblSphere3)
        Me.Scholar.Controls.Add(Me.costSphere3)
        Me.Scholar.Controls.Add(Me.ddlSphere1)
        Me.Scholar.Controls.Add(Me.ddlSphere2)
        Me.Scholar.Controls.Add(Me.ddlSphere3)
        Me.Scholar.Controls.Add(Me.skillSpellRitual)
        Me.Scholar.Controls.Add(Me.skillSpell1)
        Me.Scholar.Controls.Add(Me.skillSpell2)
        Me.Scholar.Controls.Add(Me.skillSpell3)
        Me.Scholar.Controls.Add(Me.skillSpell4)
        Me.Scholar.Controls.Add(Me.skillSpell5)
        Me.Scholar.Controls.Add(Me.skillSpell9)
        Me.Scholar.Controls.Add(Me.skillSpell8)
        Me.Scholar.Controls.Add(Me.skillSpell7)
        Me.Scholar.Controls.Add(Me.skillSpell6)
        Me.Scholar.Controls.Add(Me.CostRitualCircle)
        Me.Scholar.Controls.Add(Me.costSpell1)
        Me.Scholar.Controls.Add(Me.costSpell2)
        Me.Scholar.Controls.Add(Me.costSpell3)
        Me.Scholar.Controls.Add(Me.costSpell4)
        Me.Scholar.Controls.Add(Me.costSpell5)
        Me.Scholar.Controls.Add(Me.costSpell6)
        Me.Scholar.Controls.Add(Me.costSpell7)
        Me.Scholar.Controls.Add(Me.costSpell8)
        Me.Scholar.Controls.Add(Me.costSpell9)
        Me.Scholar.Location = New System.Drawing.Point(4, 25)
        Me.Scholar.Name = "Scholar"
        Me.Scholar.Padding = New System.Windows.Forms.Padding(3)
        Me.Scholar.Size = New System.Drawing.Size(668, 451)
        Me.Scholar.TabIndex = 1
        Me.Scholar.Text = "                   Scholar                  "
        Me.Scholar.UseVisualStyleBackColor = True
        '
        'lblPyramid
        '
        Me.lblPyramid.AutoSize = True
        Me.lblPyramid.Location = New System.Drawing.Point(17, 353)
        Me.lblPyramid.MaximumSize = New System.Drawing.Size(159, 0)
        Me.lblPyramid.Name = "lblPyramid"
        Me.lblPyramid.Size = New System.Drawing.Size(97, 13)
        Me.lblPyramid.TabIndex = 281
        Me.lblPyramid.Text = "Spell Pyramid up to"
        '
        'lblPyramidOrSpinners
        '
        Me.lblPyramidOrSpinners.AutoSize = True
        Me.lblPyramidOrSpinners.Location = New System.Drawing.Point(17, 392)
        Me.lblPyramidOrSpinners.MaximumSize = New System.Drawing.Size(159, 0)
        Me.lblPyramidOrSpinners.Name = "lblPyramidOrSpinners"
        Me.lblPyramidOrSpinners.Size = New System.Drawing.Size(149, 26)
        Me.lblPyramidOrSpinners.TabIndex = 280
        Me.lblPyramidOrSpinners.Text = "Please note selecting 5 or higher adds 'Read Magic Adv'"
        '
        'ddlPyramid
        '
        Me.ddlPyramid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlPyramid.FormattingEnabled = True
        Me.ddlPyramid.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ddlPyramid.Location = New System.Drawing.Point(20, 368)
        Me.ddlPyramid.Name = "ddlPyramid"
        Me.ddlPyramid.Size = New System.Drawing.Size(91, 21)
        Me.ddlPyramid.TabIndex = 279
        Me.ddlPyramid.TabStop = False
        '
        'costAdvRitual
        '
        Me.costAdvRitual.AutoSize = True
        Me.costAdvRitual.Location = New System.Drawing.Point(561, 392)
        Me.costAdvRitual.Name = "costAdvRitual"
        Me.costAdvRitual.Size = New System.Drawing.Size(13, 13)
        Me.costAdvRitual.TabIndex = 278
        Me.costAdvRitual.Text = "0"
        '
        'lblAdvRitual
        '
        Me.lblAdvRitual.AutoSize = True
        Me.lblAdvRitual.Location = New System.Drawing.Point(524, 353)
        Me.lblAdvRitual.Name = "lblAdvRitual"
        Me.lblAdvRitual.Size = New System.Drawing.Size(97, 13)
        Me.lblAdvRitual.TabIndex = 277
        Me.lblAdvRitual.Text = "Adv. Ritual Casting"
        '
        'skillAdvRitual
        '
        Me.skillAdvRitual.Location = New System.Drawing.Point(552, 369)
        Me.skillAdvRitual.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillAdvRitual.Name = "skillAdvRitual"
        Me.skillAdvRitual.ReadOnly = True
        Me.skillAdvRitual.Size = New System.Drawing.Size(30, 20)
        Me.skillAdvRitual.TabIndex = 276
        Me.skillAdvRitual.TabStop = False
        Me.skillAdvRitual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.skillAdvRitual.Value = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(123, 352)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 13)
        Me.Label31.TabIndex = 275
        Me.Label31.Text = "Level"
        '
        'lblSpellSlots
        '
        Me.lblSpellSlots.AutoSize = True
        Me.lblSpellSlots.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellSlots.Location = New System.Drawing.Point(295, 328)
        Me.lblSpellSlots.Name = "lblSpellSlots"
        Me.lblSpellSlots.Size = New System.Drawing.Size(67, 13)
        Me.lblSpellSlots.TabIndex = 274
        Me.lblSpellSlots.Text = "Spell Slots"
        '
        'ddlEleAttunement4
        '
        Me.ddlEleAttunement4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlEleAttunement4.FormattingEnabled = True
        Me.ddlEleAttunement4.Location = New System.Drawing.Point(492, 309)
        Me.ddlEleAttunement4.Name = "ddlEleAttunement4"
        Me.ddlEleAttunement4.Size = New System.Drawing.Size(145, 21)
        Me.ddlEleAttunement4.TabIndex = 273
        Me.ddlEleAttunement4.TabStop = False
        Me.ddlEleAttunement4.Visible = False
        '
        'ddlEleAttunement3
        '
        Me.ddlEleAttunement3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlEleAttunement3.FormattingEnabled = True
        Me.ddlEleAttunement3.Location = New System.Drawing.Point(492, 282)
        Me.ddlEleAttunement3.Name = "ddlEleAttunement3"
        Me.ddlEleAttunement3.Size = New System.Drawing.Size(145, 21)
        Me.ddlEleAttunement3.TabIndex = 272
        Me.ddlEleAttunement3.TabStop = False
        Me.ddlEleAttunement3.Visible = False
        '
        'ddlEleAttunement2
        '
        Me.ddlEleAttunement2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlEleAttunement2.FormattingEnabled = True
        Me.ddlEleAttunement2.Location = New System.Drawing.Point(492, 254)
        Me.ddlEleAttunement2.Name = "ddlEleAttunement2"
        Me.ddlEleAttunement2.Size = New System.Drawing.Size(145, 21)
        Me.ddlEleAttunement2.TabIndex = 271
        Me.ddlEleAttunement2.TabStop = False
        Me.ddlEleAttunement2.Visible = False
        '
        'ddlEleAttunement1
        '
        Me.ddlEleAttunement1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlEleAttunement1.FormattingEnabled = True
        Me.ddlEleAttunement1.Items.AddRange(New Object() {"Fire", "Stone", "Ice", "Lightning"})
        Me.ddlEleAttunement1.Location = New System.Drawing.Point(32, 282)
        Me.ddlEleAttunement1.Name = "ddlEleAttunement1"
        Me.ddlEleAttunement1.Size = New System.Drawing.Size(145, 21)
        Me.ddlEleAttunement1.TabIndex = 270
        Me.ddlEleAttunement1.TabStop = False
        Me.ddlEleAttunement1.Visible = False
        '
        'skillPhysician
        '
        Me.skillPhysician.Location = New System.Drawing.Point(452, 92)
        Me.skillPhysician.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.skillPhysician.Name = "skillPhysician"
        Me.skillPhysician.ReadOnly = True
        Me.skillPhysician.Size = New System.Drawing.Size(33, 20)
        Me.skillPhysician.TabIndex = 68
        Me.skillPhysician.TabStop = False
        '
        'skillAnatomy
        '
        Me.skillAnatomy.Location = New System.Drawing.Point(144, 93)
        Me.skillAnatomy.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillAnatomy.Name = "skillAnatomy"
        Me.skillAnatomy.ReadOnly = True
        Me.skillAnatomy.Size = New System.Drawing.Size(33, 20)
        Me.skillAnatomy.TabIndex = 47
        Me.skillAnatomy.TabStop = False
        '
        'lblAnatomy
        '
        Me.lblAnatomy.AutoSize = True
        Me.lblAnatomy.Location = New System.Drawing.Point(29, 95)
        Me.lblAnatomy.Name = "lblAnatomy"
        Me.lblAnatomy.Size = New System.Drawing.Size(48, 13)
        Me.lblAnatomy.TabIndex = 48
        Me.lblAnatomy.Text = "Anatomy"
        '
        'costAnatomy
        '
        Me.costAnatomy.AutoSize = True
        Me.costAnatomy.Location = New System.Drawing.Point(119, 95)
        Me.costAnatomy.Name = "costAnatomy"
        Me.costAnatomy.Size = New System.Drawing.Size(13, 13)
        Me.costAnatomy.TabIndex = 49
        Me.costAnatomy.Text = "0"
        '
        'skillMysticism
        '
        Me.skillMysticism.Location = New System.Drawing.Point(144, 27)
        Me.skillMysticism.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.skillMysticism.Name = "skillMysticism"
        Me.skillMysticism.ReadOnly = True
        Me.skillMysticism.Size = New System.Drawing.Size(33, 20)
        Me.skillMysticism.TabIndex = 53
        Me.skillMysticism.TabStop = False
        '
        'lblMysticism
        '
        Me.lblMysticism.AutoSize = True
        Me.lblMysticism.Location = New System.Drawing.Point(29, 30)
        Me.lblMysticism.Name = "lblMysticism"
        Me.lblMysticism.Size = New System.Drawing.Size(52, 13)
        Me.lblMysticism.TabIndex = 54
        Me.lblMysticism.Text = "Mysticism"
        '
        'costMysticism
        '
        Me.costMysticism.AutoSize = True
        Me.costMysticism.Location = New System.Drawing.Point(119, 30)
        Me.costMysticism.Name = "costMysticism"
        Me.costMysticism.Size = New System.Drawing.Size(19, 13)
        Me.costMysticism.TabIndex = 55
        Me.costMysticism.Text = "50"
        '
        'skillDemonAngelArts
        '
        Me.skillDemonAngelArts.Location = New System.Drawing.Point(298, 28)
        Me.skillDemonAngelArts.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillDemonAngelArts.Name = "skillDemonAngelArts"
        Me.skillDemonAngelArts.ReadOnly = True
        Me.skillDemonAngelArts.Size = New System.Drawing.Size(33, 20)
        Me.skillDemonAngelArts.TabIndex = 56
        Me.skillDemonAngelArts.TabStop = False
        '
        'lblDemonAngelArts
        '
        Me.lblDemonAngelArts.AutoSize = True
        Me.lblDemonAngelArts.Location = New System.Drawing.Point(183, 30)
        Me.lblDemonAngelArts.Name = "lblDemonAngelArts"
        Me.lblDemonAngelArts.Size = New System.Drawing.Size(94, 13)
        Me.lblDemonAngelArts.TabIndex = 57
        Me.lblDemonAngelArts.Text = "Demon/Angel Arts"
        '
        'costDemonAngelArts
        '
        Me.costDemonAngelArts.AutoSize = True
        Me.costDemonAngelArts.Location = New System.Drawing.Point(275, 30)
        Me.costDemonAngelArts.Name = "costDemonAngelArts"
        Me.costDemonAngelArts.Size = New System.Drawing.Size(13, 13)
        Me.costDemonAngelArts.TabIndex = 58
        Me.costDemonAngelArts.Text = "0"
        '
        'skillEleAttunement
        '
        Me.skillEleAttunement.Location = New System.Drawing.Point(601, 228)
        Me.skillEleAttunement.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.skillEleAttunement.Name = "skillEleAttunement"
        Me.skillEleAttunement.ReadOnly = True
        Me.skillEleAttunement.Size = New System.Drawing.Size(33, 20)
        Me.skillEleAttunement.TabIndex = 59
        Me.skillEleAttunement.TabStop = False
        '
        'lblEleAttunement
        '
        Me.lblEleAttunement.AutoSize = True
        Me.lblEleAttunement.Location = New System.Drawing.Point(492, 230)
        Me.lblEleAttunement.Name = "lblEleAttunement"
        Me.lblEleAttunement.Size = New System.Drawing.Size(90, 13)
        Me.lblEleAttunement.TabIndex = 60
        Me.lblEleAttunement.Text = "Elem. Attunement"
        '
        'costEleAttunement
        '
        Me.costEleAttunement.AutoSize = True
        Me.costEleAttunement.Location = New System.Drawing.Point(582, 230)
        Me.costEleAttunement.Name = "costEleAttunement"
        Me.costEleAttunement.Size = New System.Drawing.Size(13, 13)
        Me.costEleAttunement.TabIndex = 61
        Me.costEleAttunement.Text = "0"
        '
        'skillFirstAid
        '
        Me.skillFirstAid.Location = New System.Drawing.Point(298, 93)
        Me.skillFirstAid.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillFirstAid.Name = "skillFirstAid"
        Me.skillFirstAid.ReadOnly = True
        Me.skillFirstAid.Size = New System.Drawing.Size(33, 20)
        Me.skillFirstAid.TabIndex = 62
        Me.skillFirstAid.TabStop = False
        '
        'lblFirstAid
        '
        Me.lblFirstAid.AutoSize = True
        Me.lblFirstAid.Location = New System.Drawing.Point(183, 95)
        Me.lblFirstAid.Name = "lblFirstAid"
        Me.lblFirstAid.Size = New System.Drawing.Size(44, 13)
        Me.lblFirstAid.TabIndex = 63
        Me.lblFirstAid.Text = "First Aid"
        '
        'costFirstAid
        '
        Me.costFirstAid.AutoSize = True
        Me.costFirstAid.Location = New System.Drawing.Point(273, 95)
        Me.costFirstAid.Name = "costFirstAid"
        Me.costFirstAid.Size = New System.Drawing.Size(13, 13)
        Me.costFirstAid.TabIndex = 64
        Me.costFirstAid.Text = "0"
        '
        'skillNecroArts
        '
        Me.skillNecroArts.Location = New System.Drawing.Point(452, 28)
        Me.skillNecroArts.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillNecroArts.Name = "skillNecroArts"
        Me.skillNecroArts.ReadOnly = True
        Me.skillNecroArts.Size = New System.Drawing.Size(33, 20)
        Me.skillNecroArts.TabIndex = 65
        Me.skillNecroArts.TabStop = False
        '
        'lblNecroArts
        '
        Me.lblNecroArts.AutoSize = True
        Me.lblNecroArts.Location = New System.Drawing.Point(337, 31)
        Me.lblNecroArts.Name = "lblNecroArts"
        Me.lblNecroArts.Size = New System.Drawing.Size(88, 13)
        Me.lblNecroArts.TabIndex = 66
        Me.lblNecroArts.Text = "Necromantic Arts"
        '
        'costNecroArts
        '
        Me.costNecroArts.AutoSize = True
        Me.costNecroArts.Location = New System.Drawing.Point(427, 31)
        Me.costNecroArts.Name = "costNecroArts"
        Me.costNecroArts.Size = New System.Drawing.Size(13, 13)
        Me.costNecroArts.TabIndex = 67
        Me.costNecroArts.Text = "0"
        '
        'lblPhysician
        '
        Me.lblPhysician.AutoSize = True
        Me.lblPhysician.Location = New System.Drawing.Point(337, 95)
        Me.lblPhysician.Name = "lblPhysician"
        Me.lblPhysician.Size = New System.Drawing.Size(52, 13)
        Me.lblPhysician.TabIndex = 69
        Me.lblPhysician.Text = "Physician"
        '
        'costPhysician
        '
        Me.costPhysician.AutoSize = True
        Me.costPhysician.Location = New System.Drawing.Point(429, 95)
        Me.costPhysician.Name = "costPhysician"
        Me.costPhysician.Size = New System.Drawing.Size(13, 13)
        Me.costPhysician.TabIndex = 70
        Me.costPhysician.Text = "0"
        '
        'skillReadAndWrite
        '
        Me.skillReadAndWrite.Location = New System.Drawing.Point(144, 167)
        Me.skillReadAndWrite.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillReadAndWrite.Name = "skillReadAndWrite"
        Me.skillReadAndWrite.ReadOnly = True
        Me.skillReadAndWrite.Size = New System.Drawing.Size(33, 20)
        Me.skillReadAndWrite.TabIndex = 71
        Me.skillReadAndWrite.TabStop = False
        '
        'lblReadAndWrite
        '
        Me.lblReadAndWrite.AutoSize = True
        Me.lblReadAndWrite.Location = New System.Drawing.Point(29, 169)
        Me.lblReadAndWrite.Name = "lblReadAndWrite"
        Me.lblReadAndWrite.Size = New System.Drawing.Size(82, 13)
        Me.lblReadAndWrite.TabIndex = 72
        Me.lblReadAndWrite.Text = "Read and Write"
        '
        'costReadAndWrite
        '
        Me.costReadAndWrite.AutoSize = True
        Me.costReadAndWrite.Location = New System.Drawing.Point(119, 169)
        Me.costReadAndWrite.Name = "costReadAndWrite"
        Me.costReadAndWrite.Size = New System.Drawing.Size(13, 13)
        Me.costReadAndWrite.TabIndex = 73
        Me.costReadAndWrite.Text = "0"
        '
        'costSpellRitual
        '
        Me.costSpellRitual.AutoSize = True
        Me.costSpellRitual.Location = New System.Drawing.Point(493, 392)
        Me.costSpellRitual.Name = "costSpellRitual"
        Me.costSpellRitual.Size = New System.Drawing.Size(13, 13)
        Me.costSpellRitual.TabIndex = 269
        Me.costSpellRitual.Text = "0"
        '
        'skillReadMagic
        '
        Me.skillReadMagic.Location = New System.Drawing.Point(298, 167)
        Me.skillReadMagic.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillReadMagic.Name = "skillReadMagic"
        Me.skillReadMagic.ReadOnly = True
        Me.skillReadMagic.Size = New System.Drawing.Size(33, 20)
        Me.skillReadMagic.TabIndex = 74
        Me.skillReadMagic.TabStop = False
        '
        'lblReadMagic
        '
        Me.lblReadMagic.AutoSize = True
        Me.lblReadMagic.Location = New System.Drawing.Point(183, 169)
        Me.lblReadMagic.Name = "lblReadMagic"
        Me.lblReadMagic.Size = New System.Drawing.Size(65, 13)
        Me.lblReadMagic.TabIndex = 75
        Me.lblReadMagic.Text = "Read Magic"
        '
        'costReadMagic
        '
        Me.costReadMagic.AutoSize = True
        Me.costReadMagic.Location = New System.Drawing.Point(273, 169)
        Me.costReadMagic.Name = "costReadMagic"
        Me.costReadMagic.Size = New System.Drawing.Size(13, 13)
        Me.costReadMagic.TabIndex = 76
        Me.costReadMagic.Text = "0"
        '
        'skillReadMagicAvd
        '
        Me.skillReadMagicAvd.Location = New System.Drawing.Point(452, 166)
        Me.skillReadMagicAvd.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillReadMagicAvd.Name = "skillReadMagicAvd"
        Me.skillReadMagicAvd.ReadOnly = True
        Me.skillReadMagicAvd.Size = New System.Drawing.Size(33, 20)
        Me.skillReadMagicAvd.TabIndex = 77
        Me.skillReadMagicAvd.TabStop = False
        '
        'lblReadMagicAvd
        '
        Me.lblReadMagicAvd.AutoSize = True
        Me.lblReadMagicAvd.Location = New System.Drawing.Point(337, 168)
        Me.lblReadMagicAvd.Name = "lblReadMagicAvd"
        Me.lblReadMagicAvd.Size = New System.Drawing.Size(78, 13)
        Me.lblReadMagicAvd.TabIndex = 78
        Me.lblReadMagicAvd.Text = "Rd Magic Adv."
        '
        'costReadMagicAvd
        '
        Me.costReadMagicAvd.AutoSize = True
        Me.costReadMagicAvd.Location = New System.Drawing.Point(429, 169)
        Me.costReadMagicAvd.Name = "costReadMagicAvd"
        Me.costReadMagicAvd.Size = New System.Drawing.Size(13, 13)
        Me.costReadMagicAvd.TabIndex = 79
        Me.costReadMagicAvd.Text = "0"
        '
        'lblRitual
        '
        Me.lblRitual.AutoSize = True
        Me.lblRitual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRitual.Location = New System.Drawing.Point(494, 353)
        Me.lblRitual.Name = "lblRitual"
        Me.lblRitual.Size = New System.Drawing.Size(16, 13)
        Me.lblRitual.TabIndex = 250
        Me.lblRitual.Text = "R"
        '
        'skillReadMagicRitual
        '
        Me.skillReadMagicRitual.Location = New System.Drawing.Point(606, 166)
        Me.skillReadMagicRitual.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillReadMagicRitual.Name = "skillReadMagicRitual"
        Me.skillReadMagicRitual.ReadOnly = True
        Me.skillReadMagicRitual.Size = New System.Drawing.Size(33, 20)
        Me.skillReadMagicRitual.TabIndex = 80
        Me.skillReadMagicRitual.TabStop = False
        '
        'lblSpellLevel9
        '
        Me.lblSpellLevel9.AutoSize = True
        Me.lblSpellLevel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellLevel9.Location = New System.Drawing.Point(461, 353)
        Me.lblSpellLevel9.Name = "lblSpellLevel9"
        Me.lblSpellLevel9.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellLevel9.TabIndex = 249
        Me.lblSpellLevel9.Text = "9"
        '
        'lblReadMagicRitual
        '
        Me.lblReadMagicRitual.AutoSize = True
        Me.lblReadMagicRitual.Location = New System.Drawing.Point(491, 169)
        Me.lblReadMagicRitual.Name = "lblReadMagicRitual"
        Me.lblReadMagicRitual.Size = New System.Drawing.Size(83, 13)
        Me.lblReadMagicRitual.TabIndex = 81
        Me.lblReadMagicRitual.Text = "Rd Magic Ritual"
        '
        'lblSpellLevel8
        '
        Me.lblSpellLevel8.AutoSize = True
        Me.lblSpellLevel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellLevel8.Location = New System.Drawing.Point(426, 353)
        Me.lblSpellLevel8.Name = "lblSpellLevel8"
        Me.lblSpellLevel8.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellLevel8.TabIndex = 248
        Me.lblSpellLevel8.Text = "8"
        '
        'costReadMagicRitual
        '
        Me.costReadMagicRitual.AutoSize = True
        Me.costReadMagicRitual.Location = New System.Drawing.Point(581, 169)
        Me.costReadMagicRitual.Name = "costReadMagicRitual"
        Me.costReadMagicRitual.Size = New System.Drawing.Size(13, 13)
        Me.costReadMagicRitual.TabIndex = 82
        Me.costReadMagicRitual.Text = "0"
        '
        'lblSpellLevel7
        '
        Me.lblSpellLevel7.AutoSize = True
        Me.lblSpellLevel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellLevel7.Location = New System.Drawing.Point(389, 353)
        Me.lblSpellLevel7.Name = "lblSpellLevel7"
        Me.lblSpellLevel7.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellLevel7.TabIndex = 247
        Me.lblSpellLevel7.Text = "7"
        '
        'skillSphere1
        '
        Me.skillSphere1.Location = New System.Drawing.Point(144, 228)
        Me.skillSphere1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSphere1.Name = "skillSphere1"
        Me.skillSphere1.ReadOnly = True
        Me.skillSphere1.Size = New System.Drawing.Size(33, 20)
        Me.skillSphere1.TabIndex = 83
        Me.skillSphere1.TabStop = False
        '
        'lblSpellLevel6
        '
        Me.lblSpellLevel6.AutoSize = True
        Me.lblSpellLevel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellLevel6.Location = New System.Drawing.Point(354, 353)
        Me.lblSpellLevel6.Name = "lblSpellLevel6"
        Me.lblSpellLevel6.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellLevel6.TabIndex = 246
        Me.lblSpellLevel6.Text = "6"
        '
        'lblSphere1
        '
        Me.lblSphere1.AutoSize = True
        Me.lblSphere1.Location = New System.Drawing.Point(29, 231)
        Me.lblSphere1.Name = "lblSphere1"
        Me.lblSphere1.Size = New System.Drawing.Size(50, 13)
        Me.lblSphere1.TabIndex = 84
        Me.lblSphere1.Text = "Sphere 1"
        '
        'lblSpellLevel5
        '
        Me.lblSpellLevel5.AutoSize = True
        Me.lblSpellLevel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellLevel5.Location = New System.Drawing.Point(318, 353)
        Me.lblSpellLevel5.Name = "lblSpellLevel5"
        Me.lblSpellLevel5.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellLevel5.TabIndex = 245
        Me.lblSpellLevel5.Text = "5"
        '
        'costSphere1
        '
        Me.costSphere1.AutoSize = True
        Me.costSphere1.Location = New System.Drawing.Point(119, 231)
        Me.costSphere1.Name = "costSphere1"
        Me.costSphere1.Size = New System.Drawing.Size(13, 13)
        Me.costSphere1.TabIndex = 85
        Me.costSphere1.Text = "0"
        '
        'lblSpellLevel4
        '
        Me.lblSpellLevel4.AutoSize = True
        Me.lblSpellLevel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellLevel4.Location = New System.Drawing.Point(282, 353)
        Me.lblSpellLevel4.Name = "lblSpellLevel4"
        Me.lblSpellLevel4.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellLevel4.TabIndex = 244
        Me.lblSpellLevel4.Text = "4"
        '
        'skillSphere2
        '
        Me.skillSphere2.Location = New System.Drawing.Point(298, 229)
        Me.skillSphere2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSphere2.Name = "skillSphere2"
        Me.skillSphere2.ReadOnly = True
        Me.skillSphere2.Size = New System.Drawing.Size(33, 20)
        Me.skillSphere2.TabIndex = 86
        Me.skillSphere2.TabStop = False
        '
        'lblSpellLevel3
        '
        Me.lblSpellLevel3.AutoSize = True
        Me.lblSpellLevel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellLevel3.Location = New System.Drawing.Point(248, 353)
        Me.lblSpellLevel3.Name = "lblSpellLevel3"
        Me.lblSpellLevel3.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellLevel3.TabIndex = 243
        Me.lblSpellLevel3.Text = "3"
        '
        'lblSphere2
        '
        Me.lblSphere2.AutoSize = True
        Me.lblSphere2.Location = New System.Drawing.Point(183, 231)
        Me.lblSphere2.Name = "lblSphere2"
        Me.lblSphere2.Size = New System.Drawing.Size(50, 13)
        Me.lblSphere2.TabIndex = 87
        Me.lblSphere2.Text = "Sphere 2"
        '
        'lblSpellLevel2
        '
        Me.lblSpellLevel2.AutoSize = True
        Me.lblSpellLevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellLevel2.Location = New System.Drawing.Point(210, 353)
        Me.lblSpellLevel2.Name = "lblSpellLevel2"
        Me.lblSpellLevel2.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellLevel2.TabIndex = 242
        Me.lblSpellLevel2.Text = "2"
        '
        'costSphere2
        '
        Me.costSphere2.AutoSize = True
        Me.costSphere2.Location = New System.Drawing.Point(273, 231)
        Me.costSphere2.Name = "costSphere2"
        Me.costSphere2.Size = New System.Drawing.Size(13, 13)
        Me.costSphere2.TabIndex = 88
        Me.costSphere2.Text = "0"
        '
        'lblSpellLevel1
        '
        Me.lblSpellLevel1.AutoSize = True
        Me.lblSpellLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellLevel1.Location = New System.Drawing.Point(173, 353)
        Me.lblSpellLevel1.Name = "lblSpellLevel1"
        Me.lblSpellLevel1.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellLevel1.TabIndex = 241
        Me.lblSpellLevel1.Text = "1"
        '
        'skillSphere3
        '
        Me.skillSphere3.Location = New System.Drawing.Point(453, 229)
        Me.skillSphere3.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSphere3.Name = "skillSphere3"
        Me.skillSphere3.ReadOnly = True
        Me.skillSphere3.Size = New System.Drawing.Size(33, 20)
        Me.skillSphere3.TabIndex = 89
        Me.skillSphere3.TabStop = False
        '
        'lblSphere3
        '
        Me.lblSphere3.AutoSize = True
        Me.lblSphere3.Location = New System.Drawing.Point(338, 231)
        Me.lblSphere3.Name = "lblSphere3"
        Me.lblSphere3.Size = New System.Drawing.Size(50, 13)
        Me.lblSphere3.TabIndex = 90
        Me.lblSphere3.Text = "Sphere 3"
        '
        'costSphere3
        '
        Me.costSphere3.AutoSize = True
        Me.costSphere3.Location = New System.Drawing.Point(429, 230)
        Me.costSphere3.Name = "costSphere3"
        Me.costSphere3.Size = New System.Drawing.Size(13, 13)
        Me.costSphere3.TabIndex = 91
        Me.costSphere3.Text = "0"
        '
        'ddlSphere1
        '
        Me.ddlSphere1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSphere1.FormattingEnabled = True
        Me.ddlSphere1.Items.AddRange(New Object() {"Elemental", "Healing", "Nature", "Protections", "Psionics", "Sigil", "Necromancy", "Wytchcraft", "Dark", "Light", "Draconic"})
        Me.ddlSphere1.Location = New System.Drawing.Point(32, 254)
        Me.ddlSphere1.Name = "ddlSphere1"
        Me.ddlSphere1.Size = New System.Drawing.Size(145, 21)
        Me.ddlSphere1.TabIndex = 92
        Me.ddlSphere1.TabStop = False
        '
        'ddlSphere2
        '
        Me.ddlSphere2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSphere2.FormattingEnabled = True
        Me.ddlSphere2.Items.AddRange(New Object() {"Elemental", "Healing", "Nature", "Protections", "Psionics", "Sigil", "Necromancy", "Wytchcraft", "Dark", "Light", "Draconic"})
        Me.ddlSphere2.Location = New System.Drawing.Point(186, 255)
        Me.ddlSphere2.Name = "ddlSphere2"
        Me.ddlSphere2.Size = New System.Drawing.Size(145, 21)
        Me.ddlSphere2.TabIndex = 93
        Me.ddlSphere2.TabStop = False
        '
        'ddlSphere3
        '
        Me.ddlSphere3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSphere3.FormattingEnabled = True
        Me.ddlSphere3.Items.AddRange(New Object() {"Elemental", "Healing", "Nature", "Protections", "Psionics", "Sigil", "Necromancy", "Wytchcraft", "Dark", "Light", "Draconic"})
        Me.ddlSphere3.Location = New System.Drawing.Point(341, 255)
        Me.ddlSphere3.Name = "ddlSphere3"
        Me.ddlSphere3.Size = New System.Drawing.Size(145, 21)
        Me.ddlSphere3.TabIndex = 94
        Me.ddlSphere3.TabStop = False
        '
        'skillSpellRitual
        '
        Me.skillSpellRitual.Location = New System.Drawing.Point(488, 369)
        Me.skillSpellRitual.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.skillSpellRitual.Name = "skillSpellRitual"
        Me.skillSpellRitual.ReadOnly = True
        Me.skillSpellRitual.Size = New System.Drawing.Size(30, 20)
        Me.skillSpellRitual.TabIndex = 16
        Me.skillSpellRitual.TabStop = False
        Me.skillSpellRitual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skillSpell1
        '
        Me.skillSpell1.Location = New System.Drawing.Point(164, 369)
        Me.skillSpell1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.skillSpell1.Name = "skillSpell1"
        Me.skillSpell1.ReadOnly = True
        Me.skillSpell1.Size = New System.Drawing.Size(30, 20)
        Me.skillSpell1.TabIndex = 10
        Me.skillSpell1.TabStop = False
        Me.skillSpell1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skillSpell2
        '
        Me.skillSpell2.Location = New System.Drawing.Point(200, 369)
        Me.skillSpell2.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.skillSpell2.Name = "skillSpell2"
        Me.skillSpell2.ReadOnly = True
        Me.skillSpell2.Size = New System.Drawing.Size(30, 20)
        Me.skillSpell2.TabIndex = 11
        Me.skillSpell2.TabStop = False
        Me.skillSpell2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skillSpell3
        '
        Me.skillSpell3.Location = New System.Drawing.Point(236, 369)
        Me.skillSpell3.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.skillSpell3.Name = "skillSpell3"
        Me.skillSpell3.ReadOnly = True
        Me.skillSpell3.Size = New System.Drawing.Size(30, 20)
        Me.skillSpell3.TabIndex = 12
        Me.skillSpell3.TabStop = False
        Me.skillSpell3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skillSpell4
        '
        Me.skillSpell4.Location = New System.Drawing.Point(272, 369)
        Me.skillSpell4.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.skillSpell4.Name = "skillSpell4"
        Me.skillSpell4.ReadOnly = True
        Me.skillSpell4.Size = New System.Drawing.Size(30, 20)
        Me.skillSpell4.TabIndex = 13
        Me.skillSpell4.TabStop = False
        Me.skillSpell4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skillSpell5
        '
        Me.skillSpell5.Location = New System.Drawing.Point(308, 369)
        Me.skillSpell5.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.skillSpell5.Name = "skillSpell5"
        Me.skillSpell5.ReadOnly = True
        Me.skillSpell5.Size = New System.Drawing.Size(30, 20)
        Me.skillSpell5.TabIndex = 14
        Me.skillSpell5.TabStop = False
        Me.skillSpell5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skillSpell9
        '
        Me.skillSpell9.Location = New System.Drawing.Point(452, 369)
        Me.skillSpell9.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.skillSpell9.Name = "skillSpell9"
        Me.skillSpell9.ReadOnly = True
        Me.skillSpell9.Size = New System.Drawing.Size(30, 20)
        Me.skillSpell9.TabIndex = 17
        Me.skillSpell9.TabStop = False
        Me.skillSpell9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skillSpell8
        '
        Me.skillSpell8.Location = New System.Drawing.Point(416, 369)
        Me.skillSpell8.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.skillSpell8.Name = "skillSpell8"
        Me.skillSpell8.ReadOnly = True
        Me.skillSpell8.Size = New System.Drawing.Size(30, 20)
        Me.skillSpell8.TabIndex = 18
        Me.skillSpell8.TabStop = False
        Me.skillSpell8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skillSpell7
        '
        Me.skillSpell7.Location = New System.Drawing.Point(380, 369)
        Me.skillSpell7.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.skillSpell7.Name = "skillSpell7"
        Me.skillSpell7.ReadOnly = True
        Me.skillSpell7.Size = New System.Drawing.Size(30, 20)
        Me.skillSpell7.TabIndex = 19
        Me.skillSpell7.TabStop = False
        Me.skillSpell7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skillSpell6
        '
        Me.skillSpell6.Location = New System.Drawing.Point(344, 369)
        Me.skillSpell6.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.skillSpell6.Name = "skillSpell6"
        Me.skillSpell6.ReadOnly = True
        Me.skillSpell6.Size = New System.Drawing.Size(30, 20)
        Me.skillSpell6.TabIndex = 20
        Me.skillSpell6.TabStop = False
        Me.skillSpell6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CostRitualCircle
        '
        Me.CostRitualCircle.AutoSize = True
        Me.CostRitualCircle.Location = New System.Drawing.Point(485, 353)
        Me.CostRitualCircle.Name = "CostRitualCircle"
        Me.CostRitualCircle.Size = New System.Drawing.Size(13, 13)
        Me.CostRitualCircle.TabIndex = 46
        Me.CostRitualCircle.Text = "0"
        Me.CostRitualCircle.Visible = False
        '
        'costSpell1
        '
        Me.costSpell1.AutoSize = True
        Me.costSpell1.Location = New System.Drawing.Point(172, 392)
        Me.costSpell1.Name = "costSpell1"
        Me.costSpell1.Size = New System.Drawing.Size(13, 13)
        Me.costSpell1.TabIndex = 37
        Me.costSpell1.Text = "0"
        '
        'costSpell2
        '
        Me.costSpell2.AutoSize = True
        Me.costSpell2.Location = New System.Drawing.Point(209, 392)
        Me.costSpell2.Name = "costSpell2"
        Me.costSpell2.Size = New System.Drawing.Size(13, 13)
        Me.costSpell2.TabIndex = 38
        Me.costSpell2.Text = "0"
        '
        'costSpell3
        '
        Me.costSpell3.AutoSize = True
        Me.costSpell3.Location = New System.Drawing.Point(245, 392)
        Me.costSpell3.Name = "costSpell3"
        Me.costSpell3.Size = New System.Drawing.Size(13, 13)
        Me.costSpell3.TabIndex = 39
        Me.costSpell3.Text = "0"
        '
        'costSpell4
        '
        Me.costSpell4.AutoSize = True
        Me.costSpell4.Location = New System.Drawing.Point(282, 392)
        Me.costSpell4.Name = "costSpell4"
        Me.costSpell4.Size = New System.Drawing.Size(13, 13)
        Me.costSpell4.TabIndex = 40
        Me.costSpell4.Text = "0"
        '
        'costSpell5
        '
        Me.costSpell5.AutoSize = True
        Me.costSpell5.Location = New System.Drawing.Point(318, 392)
        Me.costSpell5.Name = "costSpell5"
        Me.costSpell5.Size = New System.Drawing.Size(13, 13)
        Me.costSpell5.TabIndex = 41
        Me.costSpell5.Text = "0"
        '
        'costSpell6
        '
        Me.costSpell6.AutoSize = True
        Me.costSpell6.Location = New System.Drawing.Point(355, 392)
        Me.costSpell6.Name = "costSpell6"
        Me.costSpell6.Size = New System.Drawing.Size(13, 13)
        Me.costSpell6.TabIndex = 42
        Me.costSpell6.Text = "0"
        '
        'costSpell7
        '
        Me.costSpell7.AutoSize = True
        Me.costSpell7.Location = New System.Drawing.Point(389, 392)
        Me.costSpell7.Name = "costSpell7"
        Me.costSpell7.Size = New System.Drawing.Size(13, 13)
        Me.costSpell7.TabIndex = 43
        Me.costSpell7.Text = "0"
        '
        'costSpell8
        '
        Me.costSpell8.AutoSize = True
        Me.costSpell8.Location = New System.Drawing.Point(426, 392)
        Me.costSpell8.Name = "costSpell8"
        Me.costSpell8.Size = New System.Drawing.Size(13, 13)
        Me.costSpell8.TabIndex = 44
        Me.costSpell8.Text = "0"
        '
        'costSpell9
        '
        Me.costSpell9.AutoSize = True
        Me.costSpell9.Location = New System.Drawing.Point(461, 392)
        Me.costSpell9.Name = "costSpell9"
        Me.costSpell9.Size = New System.Drawing.Size(13, 13)
        Me.costSpell9.TabIndex = 45
        Me.costSpell9.Text = "0"
        '
        'JobRaceProd
        '
        Me.JobRaceProd.Controls.Add(Me.lblSpellVersa9)
        Me.JobRaceProd.Controls.Add(Me.lblSpellVersa8)
        Me.JobRaceProd.Controls.Add(Me.lblSpellVersa7)
        Me.JobRaceProd.Controls.Add(Me.lblSpellVersa6)
        Me.JobRaceProd.Controls.Add(Me.lblSpellVersa5)
        Me.JobRaceProd.Controls.Add(Me.lblSpellVersa4)
        Me.JobRaceProd.Controls.Add(Me.lblSpellVersa3)
        Me.JobRaceProd.Controls.Add(Me.lblSpellVersa2)
        Me.JobRaceProd.Controls.Add(Me.lblSpellVersa1)
        Me.JobRaceProd.Controls.Add(Me.skillSpellVersa1)
        Me.JobRaceProd.Controls.Add(Me.skillSpellVersa2)
        Me.JobRaceProd.Controls.Add(Me.skillSpellVersa3)
        Me.JobRaceProd.Controls.Add(Me.skillSpellVersa4)
        Me.JobRaceProd.Controls.Add(Me.skillSpellVersa5)
        Me.JobRaceProd.Controls.Add(Me.skillSpellVersa9)
        Me.JobRaceProd.Controls.Add(Me.skillSpellVersa8)
        Me.JobRaceProd.Controls.Add(Me.skillSpellVersa7)
        Me.JobRaceProd.Controls.Add(Me.skillSpellVersa6)
        Me.JobRaceProd.Controls.Add(Me.costSpellVersa1)
        Me.JobRaceProd.Controls.Add(Me.costSpellVersa2)
        Me.JobRaceProd.Controls.Add(Me.costSpellVersa3)
        Me.JobRaceProd.Controls.Add(Me.costSpellVersa4)
        Me.JobRaceProd.Controls.Add(Me.costSpellVersa5)
        Me.JobRaceProd.Controls.Add(Me.costSpellVersa6)
        Me.JobRaceProd.Controls.Add(Me.costSpellVersa7)
        Me.JobRaceProd.Controls.Add(Me.costSpellVersa8)
        Me.JobRaceProd.Controls.Add(Me.costSpellVersa9)
        Me.JobRaceProd.Controls.Add(Me.lblSpellVersa)
        Me.JobRaceProd.Controls.Add(Me.skillHeavyDrinker)
        Me.JobRaceProd.Controls.Add(Me.costHeavyDrinker)
        Me.JobRaceProd.Controls.Add(Me.lblHeavyDrinker)
        Me.JobRaceProd.Controls.Add(Me.skillFrag6)
        Me.JobRaceProd.Controls.Add(Me.skillFrag5)
        Me.JobRaceProd.Controls.Add(Me.skillFrag4)
        Me.JobRaceProd.Controls.Add(Me.B64a)
        Me.JobRaceProd.Controls.Add(Me.PictureBox1)
        Me.JobRaceProd.Controls.Add(Me.B64b)
        Me.JobRaceProd.Controls.Add(Me.boxCraft4)
        Me.JobRaceProd.Controls.Add(Me.boxCraft3)
        Me.JobRaceProd.Controls.Add(Me.boxCraft2)
        Me.JobRaceProd.Controls.Add(Me.boxCraft1)
        Me.JobRaceProd.Controls.Add(Me.skillCraft4)
        Me.JobRaceProd.Controls.Add(Me.lblCraft4)
        Me.JobRaceProd.Controls.Add(Me.costCraft4)
        Me.JobRaceProd.Controls.Add(Me.skillcraft3)
        Me.JobRaceProd.Controls.Add(Me.lblCraft3)
        Me.JobRaceProd.Controls.Add(Me.costCraft3)
        Me.JobRaceProd.Controls.Add(Me.skillCraft2)
        Me.JobRaceProd.Controls.Add(Me.lblCraft2)
        Me.JobRaceProd.Controls.Add(Me.costCraft2)
        Me.JobRaceProd.Controls.Add(Me.costFavoured)
        Me.JobRaceProd.Controls.Add(Me.FavouredCheck)
        Me.JobRaceProd.Controls.Add(Me.Label29)
        Me.JobRaceProd.Controls.Add(Me.lblRaceSkills)
        Me.JobRaceProd.Controls.Add(Me.lblJob)
        Me.JobRaceProd.Controls.Add(Me.lblProd)
        Me.JobRaceProd.Controls.Add(Me.skillFrag1)
        Me.JobRaceProd.Controls.Add(Me.lblFrag1)
        Me.JobRaceProd.Controls.Add(Me.costFrag1)
        Me.JobRaceProd.Controls.Add(Me.skillFrag2)
        Me.JobRaceProd.Controls.Add(Me.lblFrag2)
        Me.JobRaceProd.Controls.Add(Me.costFrag2)
        Me.JobRaceProd.Controls.Add(Me.costFrag6)
        Me.JobRaceProd.Controls.Add(Me.skillFrag3)
        Me.JobRaceProd.Controls.Add(Me.costFrag5)
        Me.JobRaceProd.Controls.Add(Me.lblFrag3)
        Me.JobRaceProd.Controls.Add(Me.costFrag4)
        Me.JobRaceProd.Controls.Add(Me.costFrag3)
        Me.JobRaceProd.Controls.Add(Me.skillLooting)
        Me.JobRaceProd.Controls.Add(Me.lblFrag6)
        Me.JobRaceProd.Controls.Add(Me.lblLooting)
        Me.JobRaceProd.Controls.Add(Me.lblFrag5)
        Me.JobRaceProd.Controls.Add(Me.costLooting)
        Me.JobRaceProd.Controls.Add(Me.lblFrag4)
        Me.JobRaceProd.Controls.Add(Me.lblJob1)
        Me.JobRaceProd.Controls.Add(Me.skillJob1)
        Me.JobRaceProd.Controls.Add(Me.costJob1)
        Me.JobRaceProd.Controls.Add(Me.skillJob2)
        Me.JobRaceProd.Controls.Add(Me.lblJob2)
        Me.JobRaceProd.Controls.Add(Me.costJob2)
        Me.JobRaceProd.Controls.Add(Me.skillJob3)
        Me.JobRaceProd.Controls.Add(Me.lblJob3)
        Me.JobRaceProd.Controls.Add(Me.costJob3)
        Me.JobRaceProd.Controls.Add(Me.skillJob4)
        Me.JobRaceProd.Controls.Add(Me.lblJob4)
        Me.JobRaceProd.Controls.Add(Me.costJob4)
        Me.JobRaceProd.Controls.Add(Me.skillRacial2)
        Me.JobRaceProd.Controls.Add(Me.lblRacial2)
        Me.JobRaceProd.Controls.Add(Me.costRacial2)
        Me.JobRaceProd.Controls.Add(Me.skillBPB)
        Me.JobRaceProd.Controls.Add(Me.lblBPB)
        Me.JobRaceProd.Controls.Add(Me.costBPB)
        Me.JobRaceProd.Controls.Add(Me.skillStr)
        Me.JobRaceProd.Controls.Add(Me.lblStr)
        Me.JobRaceProd.Controls.Add(Me.costStr)
        Me.JobRaceProd.Controls.Add(Me.skillRacial1)
        Me.JobRaceProd.Controls.Add(Me.lblRacial1)
        Me.JobRaceProd.Controls.Add(Me.costRacial1)
        Me.JobRaceProd.Controls.Add(Me.listRacial)
        Me.JobRaceProd.Controls.Add(Me.lblBlacksmith)
        Me.JobRaceProd.Controls.Add(Me.skillAlchemy)
        Me.JobRaceProd.Controls.Add(Me.lblAlchemy)
        Me.JobRaceProd.Controls.Add(Me.costAlchemy)
        Me.JobRaceProd.Controls.Add(Me.skillBlacksmith)
        Me.JobRaceProd.Controls.Add(Me.costBlacksmith)
        Me.JobRaceProd.Controls.Add(Me.skillCraft1)
        Me.JobRaceProd.Controls.Add(Me.lblCraft1)
        Me.JobRaceProd.Controls.Add(Me.costCraft1)
        Me.JobRaceProd.Controls.Add(Me.skillCreateScroll)
        Me.JobRaceProd.Controls.Add(Me.lblCreateScroll)
        Me.JobRaceProd.Controls.Add(Me.costCreateScroll)
        Me.JobRaceProd.Controls.Add(Me.skillTrapsmith)
        Me.JobRaceProd.Controls.Add(Me.lblTrapsmith)
        Me.JobRaceProd.Controls.Add(Me.costTrapsmith)
        Me.JobRaceProd.Location = New System.Drawing.Point(4, 25)
        Me.JobRaceProd.Name = "JobRaceProd"
        Me.JobRaceProd.Padding = New System.Windows.Forms.Padding(3)
        Me.JobRaceProd.Size = New System.Drawing.Size(668, 451)
        Me.JobRaceProd.TabIndex = 0
        Me.JobRaceProd.Text = "                   General                   "
        Me.JobRaceProd.UseVisualStyleBackColor = True
        '
        'lblSpellVersa9
        '
        Me.lblSpellVersa9.AutoSize = True
        Me.lblSpellVersa9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellVersa9.Location = New System.Drawing.Point(417, 384)
        Me.lblSpellVersa9.Name = "lblSpellVersa9"
        Me.lblSpellVersa9.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellVersa9.TabIndex = 373
        Me.lblSpellVersa9.Text = "9"
        Me.lblSpellVersa9.Visible = False
        '
        'lblSpellVersa8
        '
        Me.lblSpellVersa8.AutoSize = True
        Me.lblSpellVersa8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellVersa8.Location = New System.Drawing.Point(382, 384)
        Me.lblSpellVersa8.Name = "lblSpellVersa8"
        Me.lblSpellVersa8.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellVersa8.TabIndex = 372
        Me.lblSpellVersa8.Text = "8"
        Me.lblSpellVersa8.Visible = False
        '
        'lblSpellVersa7
        '
        Me.lblSpellVersa7.AutoSize = True
        Me.lblSpellVersa7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellVersa7.Location = New System.Drawing.Point(345, 384)
        Me.lblSpellVersa7.Name = "lblSpellVersa7"
        Me.lblSpellVersa7.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellVersa7.TabIndex = 371
        Me.lblSpellVersa7.Text = "7"
        Me.lblSpellVersa7.Visible = False
        '
        'lblSpellVersa6
        '
        Me.lblSpellVersa6.AutoSize = True
        Me.lblSpellVersa6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellVersa6.Location = New System.Drawing.Point(310, 384)
        Me.lblSpellVersa6.Name = "lblSpellVersa6"
        Me.lblSpellVersa6.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellVersa6.TabIndex = 370
        Me.lblSpellVersa6.Text = "6"
        Me.lblSpellVersa6.Visible = False
        '
        'lblSpellVersa5
        '
        Me.lblSpellVersa5.AutoSize = True
        Me.lblSpellVersa5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellVersa5.Location = New System.Drawing.Point(274, 384)
        Me.lblSpellVersa5.Name = "lblSpellVersa5"
        Me.lblSpellVersa5.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellVersa5.TabIndex = 369
        Me.lblSpellVersa5.Text = "5"
        Me.lblSpellVersa5.Visible = False
        '
        'lblSpellVersa4
        '
        Me.lblSpellVersa4.AutoSize = True
        Me.lblSpellVersa4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellVersa4.Location = New System.Drawing.Point(238, 384)
        Me.lblSpellVersa4.Name = "lblSpellVersa4"
        Me.lblSpellVersa4.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellVersa4.TabIndex = 368
        Me.lblSpellVersa4.Text = "4"
        Me.lblSpellVersa4.Visible = False
        '
        'lblSpellVersa3
        '
        Me.lblSpellVersa3.AutoSize = True
        Me.lblSpellVersa3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellVersa3.Location = New System.Drawing.Point(204, 384)
        Me.lblSpellVersa3.Name = "lblSpellVersa3"
        Me.lblSpellVersa3.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellVersa3.TabIndex = 367
        Me.lblSpellVersa3.Text = "3"
        Me.lblSpellVersa3.Visible = False
        '
        'lblSpellVersa2
        '
        Me.lblSpellVersa2.AutoSize = True
        Me.lblSpellVersa2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellVersa2.Location = New System.Drawing.Point(166, 384)
        Me.lblSpellVersa2.Name = "lblSpellVersa2"
        Me.lblSpellVersa2.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellVersa2.TabIndex = 366
        Me.lblSpellVersa2.Text = "2"
        Me.lblSpellVersa2.Visible = False
        '
        'lblSpellVersa1
        '
        Me.lblSpellVersa1.AutoSize = True
        Me.lblSpellVersa1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellVersa1.Location = New System.Drawing.Point(129, 384)
        Me.lblSpellVersa1.Name = "lblSpellVersa1"
        Me.lblSpellVersa1.Size = New System.Drawing.Size(14, 13)
        Me.lblSpellVersa1.TabIndex = 365
        Me.lblSpellVersa1.Text = "1"
        Me.lblSpellVersa1.Visible = False
        '
        'skillSpellVersa1
        '
        Me.skillSpellVersa1.Location = New System.Drawing.Point(120, 400)
        Me.skillSpellVersa1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSpellVersa1.Name = "skillSpellVersa1"
        Me.skillSpellVersa1.ReadOnly = True
        Me.skillSpellVersa1.Size = New System.Drawing.Size(30, 20)
        Me.skillSpellVersa1.TabIndex = 347
        Me.skillSpellVersa1.TabStop = False
        Me.skillSpellVersa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.skillSpellVersa1.Visible = False
        '
        'skillSpellVersa2
        '
        Me.skillSpellVersa2.Location = New System.Drawing.Point(156, 400)
        Me.skillSpellVersa2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSpellVersa2.Name = "skillSpellVersa2"
        Me.skillSpellVersa2.ReadOnly = True
        Me.skillSpellVersa2.Size = New System.Drawing.Size(30, 20)
        Me.skillSpellVersa2.TabIndex = 348
        Me.skillSpellVersa2.TabStop = False
        Me.skillSpellVersa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.skillSpellVersa2.Visible = False
        '
        'skillSpellVersa3
        '
        Me.skillSpellVersa3.Location = New System.Drawing.Point(192, 400)
        Me.skillSpellVersa3.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSpellVersa3.Name = "skillSpellVersa3"
        Me.skillSpellVersa3.ReadOnly = True
        Me.skillSpellVersa3.Size = New System.Drawing.Size(30, 20)
        Me.skillSpellVersa3.TabIndex = 349
        Me.skillSpellVersa3.TabStop = False
        Me.skillSpellVersa3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.skillSpellVersa3.Visible = False
        '
        'skillSpellVersa4
        '
        Me.skillSpellVersa4.Location = New System.Drawing.Point(228, 400)
        Me.skillSpellVersa4.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSpellVersa4.Name = "skillSpellVersa4"
        Me.skillSpellVersa4.ReadOnly = True
        Me.skillSpellVersa4.Size = New System.Drawing.Size(30, 20)
        Me.skillSpellVersa4.TabIndex = 350
        Me.skillSpellVersa4.TabStop = False
        Me.skillSpellVersa4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.skillSpellVersa4.Visible = False
        '
        'skillSpellVersa5
        '
        Me.skillSpellVersa5.Location = New System.Drawing.Point(264, 400)
        Me.skillSpellVersa5.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSpellVersa5.Name = "skillSpellVersa5"
        Me.skillSpellVersa5.ReadOnly = True
        Me.skillSpellVersa5.Size = New System.Drawing.Size(30, 20)
        Me.skillSpellVersa5.TabIndex = 351
        Me.skillSpellVersa5.TabStop = False
        Me.skillSpellVersa5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.skillSpellVersa5.Visible = False
        '
        'skillSpellVersa9
        '
        Me.skillSpellVersa9.Location = New System.Drawing.Point(408, 400)
        Me.skillSpellVersa9.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSpellVersa9.Name = "skillSpellVersa9"
        Me.skillSpellVersa9.ReadOnly = True
        Me.skillSpellVersa9.Size = New System.Drawing.Size(30, 20)
        Me.skillSpellVersa9.TabIndex = 352
        Me.skillSpellVersa9.TabStop = False
        Me.skillSpellVersa9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.skillSpellVersa9.Visible = False
        '
        'skillSpellVersa8
        '
        Me.skillSpellVersa8.Location = New System.Drawing.Point(372, 400)
        Me.skillSpellVersa8.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSpellVersa8.Name = "skillSpellVersa8"
        Me.skillSpellVersa8.ReadOnly = True
        Me.skillSpellVersa8.Size = New System.Drawing.Size(30, 20)
        Me.skillSpellVersa8.TabIndex = 353
        Me.skillSpellVersa8.TabStop = False
        Me.skillSpellVersa8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.skillSpellVersa8.Visible = False
        '
        'skillSpellVersa7
        '
        Me.skillSpellVersa7.Location = New System.Drawing.Point(336, 400)
        Me.skillSpellVersa7.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSpellVersa7.Name = "skillSpellVersa7"
        Me.skillSpellVersa7.ReadOnly = True
        Me.skillSpellVersa7.Size = New System.Drawing.Size(30, 20)
        Me.skillSpellVersa7.TabIndex = 354
        Me.skillSpellVersa7.TabStop = False
        Me.skillSpellVersa7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.skillSpellVersa7.Visible = False
        '
        'skillSpellVersa6
        '
        Me.skillSpellVersa6.Location = New System.Drawing.Point(300, 400)
        Me.skillSpellVersa6.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillSpellVersa6.Name = "skillSpellVersa6"
        Me.skillSpellVersa6.ReadOnly = True
        Me.skillSpellVersa6.Size = New System.Drawing.Size(30, 20)
        Me.skillSpellVersa6.TabIndex = 355
        Me.skillSpellVersa6.TabStop = False
        Me.skillSpellVersa6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.skillSpellVersa6.Visible = False
        '
        'costSpellVersa1
        '
        Me.costSpellVersa1.AutoSize = True
        Me.costSpellVersa1.Location = New System.Drawing.Point(128, 423)
        Me.costSpellVersa1.Name = "costSpellVersa1"
        Me.costSpellVersa1.Size = New System.Drawing.Size(13, 13)
        Me.costSpellVersa1.TabIndex = 356
        Me.costSpellVersa1.Text = "0"
        Me.costSpellVersa1.Visible = False
        '
        'costSpellVersa2
        '
        Me.costSpellVersa2.AutoSize = True
        Me.costSpellVersa2.Location = New System.Drawing.Point(165, 423)
        Me.costSpellVersa2.Name = "costSpellVersa2"
        Me.costSpellVersa2.Size = New System.Drawing.Size(13, 13)
        Me.costSpellVersa2.TabIndex = 357
        Me.costSpellVersa2.Text = "0"
        Me.costSpellVersa2.Visible = False
        '
        'costSpellVersa3
        '
        Me.costSpellVersa3.AutoSize = True
        Me.costSpellVersa3.Location = New System.Drawing.Point(201, 423)
        Me.costSpellVersa3.Name = "costSpellVersa3"
        Me.costSpellVersa3.Size = New System.Drawing.Size(13, 13)
        Me.costSpellVersa3.TabIndex = 358
        Me.costSpellVersa3.Text = "0"
        Me.costSpellVersa3.Visible = False
        '
        'costSpellVersa4
        '
        Me.costSpellVersa4.AutoSize = True
        Me.costSpellVersa4.Location = New System.Drawing.Point(238, 423)
        Me.costSpellVersa4.Name = "costSpellVersa4"
        Me.costSpellVersa4.Size = New System.Drawing.Size(13, 13)
        Me.costSpellVersa4.TabIndex = 359
        Me.costSpellVersa4.Text = "0"
        Me.costSpellVersa4.Visible = False
        '
        'costSpellVersa5
        '
        Me.costSpellVersa5.AutoSize = True
        Me.costSpellVersa5.Location = New System.Drawing.Point(274, 423)
        Me.costSpellVersa5.Name = "costSpellVersa5"
        Me.costSpellVersa5.Size = New System.Drawing.Size(13, 13)
        Me.costSpellVersa5.TabIndex = 360
        Me.costSpellVersa5.Text = "0"
        Me.costSpellVersa5.Visible = False
        '
        'costSpellVersa6
        '
        Me.costSpellVersa6.AutoSize = True
        Me.costSpellVersa6.Location = New System.Drawing.Point(311, 423)
        Me.costSpellVersa6.Name = "costSpellVersa6"
        Me.costSpellVersa6.Size = New System.Drawing.Size(13, 13)
        Me.costSpellVersa6.TabIndex = 361
        Me.costSpellVersa6.Text = "0"
        Me.costSpellVersa6.Visible = False
        '
        'costSpellVersa7
        '
        Me.costSpellVersa7.AutoSize = True
        Me.costSpellVersa7.Location = New System.Drawing.Point(345, 423)
        Me.costSpellVersa7.Name = "costSpellVersa7"
        Me.costSpellVersa7.Size = New System.Drawing.Size(13, 13)
        Me.costSpellVersa7.TabIndex = 362
        Me.costSpellVersa7.Text = "0"
        Me.costSpellVersa7.Visible = False
        '
        'costSpellVersa8
        '
        Me.costSpellVersa8.AutoSize = True
        Me.costSpellVersa8.Location = New System.Drawing.Point(382, 423)
        Me.costSpellVersa8.Name = "costSpellVersa8"
        Me.costSpellVersa8.Size = New System.Drawing.Size(13, 13)
        Me.costSpellVersa8.TabIndex = 363
        Me.costSpellVersa8.Text = "0"
        Me.costSpellVersa8.Visible = False
        '
        'costSpellVersa9
        '
        Me.costSpellVersa9.AutoSize = True
        Me.costSpellVersa9.Location = New System.Drawing.Point(417, 423)
        Me.costSpellVersa9.Name = "costSpellVersa9"
        Me.costSpellVersa9.Size = New System.Drawing.Size(13, 13)
        Me.costSpellVersa9.TabIndex = 364
        Me.costSpellVersa9.Text = "0"
        Me.costSpellVersa9.Visible = False
        '
        'lblSpellVersa
        '
        Me.lblSpellVersa.AutoSize = True
        Me.lblSpellVersa.Location = New System.Drawing.Point(29, 403)
        Me.lblSpellVersa.Name = "lblSpellVersa"
        Me.lblSpellVersa.Size = New System.Drawing.Size(77, 13)
        Me.lblSpellVersa.TabIndex = 346
        Me.lblSpellVersa.Text = "Spell Versatility"
        Me.lblSpellVersa.Visible = False
        '
        'skillHeavyDrinker
        '
        Me.skillHeavyDrinker.Location = New System.Drawing.Point(608, 354)
        Me.skillHeavyDrinker.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillHeavyDrinker.Name = "skillHeavyDrinker"
        Me.skillHeavyDrinker.ReadOnly = True
        Me.skillHeavyDrinker.Size = New System.Drawing.Size(33, 20)
        Me.skillHeavyDrinker.TabIndex = 345
        Me.skillHeavyDrinker.TabStop = False
        '
        'costHeavyDrinker
        '
        Me.costHeavyDrinker.AutoSize = True
        Me.costHeavyDrinker.Location = New System.Drawing.Point(583, 356)
        Me.costHeavyDrinker.Name = "costHeavyDrinker"
        Me.costHeavyDrinker.Size = New System.Drawing.Size(19, 13)
        Me.costHeavyDrinker.TabIndex = 344
        Me.costHeavyDrinker.Text = "20"
        '
        'lblHeavyDrinker
        '
        Me.lblHeavyDrinker.AutoSize = True
        Me.lblHeavyDrinker.Location = New System.Drawing.Point(493, 356)
        Me.lblHeavyDrinker.Name = "lblHeavyDrinker"
        Me.lblHeavyDrinker.Size = New System.Drawing.Size(75, 13)
        Me.lblHeavyDrinker.TabIndex = 343
        Me.lblHeavyDrinker.Text = "Heavy Drinker"
        '
        'skillFrag6
        '
        Me.skillFrag6.Location = New System.Drawing.Point(454, 354)
        Me.skillFrag6.Name = "skillFrag6"
        Me.skillFrag6.ReadOnly = True
        Me.skillFrag6.Size = New System.Drawing.Size(33, 20)
        Me.skillFrag6.TabIndex = 342
        Me.skillFrag6.TabStop = False
        Me.skillFrag6.Visible = False
        '
        'skillFrag5
        '
        Me.skillFrag5.Location = New System.Drawing.Point(300, 354)
        Me.skillFrag5.Name = "skillFrag5"
        Me.skillFrag5.ReadOnly = True
        Me.skillFrag5.Size = New System.Drawing.Size(33, 20)
        Me.skillFrag5.TabIndex = 341
        Me.skillFrag5.TabStop = False
        Me.skillFrag5.Visible = False
        '
        'skillFrag4
        '
        Me.skillFrag4.Location = New System.Drawing.Point(144, 354)
        Me.skillFrag4.Name = "skillFrag4"
        Me.skillFrag4.ReadOnly = True
        Me.skillFrag4.Size = New System.Drawing.Size(33, 20)
        Me.skillFrag4.TabIndex = 340
        Me.skillFrag4.TabStop = False
        Me.skillFrag4.Visible = False
        '
        'B64a
        '
        Me.B64a.Location = New System.Drawing.Point(468, 178)
        Me.B64a.Name = "B64a"
        Me.B64a.Size = New System.Drawing.Size(162, 20)
        Me.B64a.TabIndex = 322
        Me.B64a.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(20, 309)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(631, 10)
        Me.PictureBox1.TabIndex = 339
        Me.PictureBox1.TabStop = False
        '
        'B64b
        '
        Me.B64b.Location = New System.Drawing.Point(286, 178)
        Me.B64b.Name = "B64b"
        Me.B64b.Size = New System.Drawing.Size(162, 20)
        Me.B64b.TabIndex = 321
        Me.B64b.Visible = False
        '
        'boxCraft4
        '
        Me.boxCraft4.Enabled = False
        Me.boxCraft4.Location = New System.Drawing.Point(494, 90)
        Me.boxCraft4.Name = "boxCraft4"
        Me.boxCraft4.Size = New System.Drawing.Size(145, 20)
        Me.boxCraft4.TabIndex = 338
        '
        'boxCraft3
        '
        Me.boxCraft3.Enabled = False
        Me.boxCraft3.Location = New System.Drawing.Point(340, 90)
        Me.boxCraft3.Name = "boxCraft3"
        Me.boxCraft3.Size = New System.Drawing.Size(145, 20)
        Me.boxCraft3.TabIndex = 337
        '
        'boxCraft2
        '
        Me.boxCraft2.Enabled = False
        Me.boxCraft2.Location = New System.Drawing.Point(186, 90)
        Me.boxCraft2.Name = "boxCraft2"
        Me.boxCraft2.Size = New System.Drawing.Size(145, 20)
        Me.boxCraft2.TabIndex = 336
        '
        'boxCraft1
        '
        Me.boxCraft1.Enabled = False
        Me.boxCraft1.Location = New System.Drawing.Point(32, 90)
        Me.boxCraft1.Name = "boxCraft1"
        Me.boxCraft1.Size = New System.Drawing.Size(145, 20)
        Me.boxCraft1.TabIndex = 324
        '
        'skillCraft4
        '
        Me.skillCraft4.Location = New System.Drawing.Point(606, 64)
        Me.skillCraft4.Name = "skillCraft4"
        Me.skillCraft4.ReadOnly = True
        Me.skillCraft4.Size = New System.Drawing.Size(33, 20)
        Me.skillCraft4.TabIndex = 333
        Me.skillCraft4.TabStop = False
        '
        'lblCraft4
        '
        Me.lblCraft4.AutoSize = True
        Me.lblCraft4.Location = New System.Drawing.Point(491, 67)
        Me.lblCraft4.Name = "lblCraft4"
        Me.lblCraft4.Size = New System.Drawing.Size(54, 13)
        Me.lblCraft4.TabIndex = 334
        Me.lblCraft4.Text = "Tradesman"
        '
        'costCraft4
        '
        Me.costCraft4.AutoSize = True
        Me.costCraft4.Location = New System.Drawing.Point(581, 67)
        Me.costCraft4.Name = "costCraft4"
        Me.costCraft4.Size = New System.Drawing.Size(13, 13)
        Me.costCraft4.TabIndex = 335
        Me.costCraft4.Text = "0"
        '
        'skillcraft3
        '
        Me.skillcraft3.Location = New System.Drawing.Point(452, 64)
        Me.skillcraft3.Name = "skillcraft3"
        Me.skillcraft3.ReadOnly = True
        Me.skillcraft3.Size = New System.Drawing.Size(33, 20)
        Me.skillcraft3.TabIndex = 330
        Me.skillcraft3.TabStop = False
        '
        'lblCraft3
        '
        Me.lblCraft3.AutoSize = True
        Me.lblCraft3.Location = New System.Drawing.Point(337, 67)
        Me.lblCraft3.Name = "lblCraft3"
        Me.lblCraft3.Size = New System.Drawing.Size(54, 13)
        Me.lblCraft3.TabIndex = 331
        Me.lblCraft3.Text = "Tradesman"
        '
        'costCraft3
        '
        Me.costCraft3.AutoSize = True
        Me.costCraft3.Location = New System.Drawing.Point(427, 67)
        Me.costCraft3.Name = "costCraft3"
        Me.costCraft3.Size = New System.Drawing.Size(13, 13)
        Me.costCraft3.TabIndex = 332
        Me.costCraft3.Text = "0"
        '
        'skillCraft2
        '
        Me.skillCraft2.Location = New System.Drawing.Point(298, 64)
        Me.skillCraft2.Name = "skillCraft2"
        Me.skillCraft2.ReadOnly = True
        Me.skillCraft2.Size = New System.Drawing.Size(33, 20)
        Me.skillCraft2.TabIndex = 327
        Me.skillCraft2.TabStop = False
        '
        'lblCraft2
        '
        Me.lblCraft2.AutoSize = True
        Me.lblCraft2.Location = New System.Drawing.Point(183, 67)
        Me.lblCraft2.Name = "lblCraft2"
        Me.lblCraft2.Size = New System.Drawing.Size(54, 13)
        Me.lblCraft2.TabIndex = 328
        Me.lblCraft2.Text = "Tradesman"
        '
        'costCraft2
        '
        Me.costCraft2.AutoSize = True
        Me.costCraft2.Location = New System.Drawing.Point(273, 67)
        Me.costCraft2.Name = "costCraft2"
        Me.costCraft2.Size = New System.Drawing.Size(13, 13)
        Me.costCraft2.TabIndex = 329
        Me.costCraft2.Text = "0"
        '
        'costFavoured
        '
        Me.costFavoured.AutoSize = True
        Me.costFavoured.Location = New System.Drawing.Point(552, 402)
        Me.costFavoured.Name = "costFavoured"
        Me.costFavoured.Size = New System.Drawing.Size(19, 13)
        Me.costFavoured.TabIndex = 324
        Me.costFavoured.Text = "50"
        '
        'FavouredCheck
        '
        Me.FavouredCheck.AutoSize = True
        Me.FavouredCheck.Location = New System.Drawing.Point(477, 401)
        Me.FavouredCheck.Name = "FavouredCheck"
        Me.FavouredCheck.Size = New System.Drawing.Size(71, 17)
        Me.FavouredCheck.TabIndex = 323
        Me.FavouredCheck.Text = "Favoured"
        Me.FavouredCheck.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(295, 291)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(66, 13)
        Me.Label29.TabIndex = 322
        Me.Label29.Text = "Frag Skills"
        '
        'lblRaceSkills
        '
        Me.lblRaceSkills.AutoSize = True
        Me.lblRaceSkills.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaceSkills.Location = New System.Drawing.Point(29, 224)
        Me.lblRaceSkills.Name = "lblRaceSkills"
        Me.lblRaceSkills.Size = New System.Drawing.Size(37, 13)
        Me.lblRaceSkills.TabIndex = 321
        Me.lblRaceSkills.Text = "Race"
        '
        'lblJob
        '
        Me.lblJob.AutoSize = True
        Me.lblJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJob.Location = New System.Drawing.Point(29, 138)
        Me.lblJob.Name = "lblJob"
        Me.lblJob.Size = New System.Drawing.Size(27, 13)
        Me.lblJob.TabIndex = 320
        Me.lblJob.Text = "Job"
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.Location = New System.Drawing.Point(29, 15)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(68, 13)
        Me.lblProd.TabIndex = 300
        Me.lblProd.Text = "Production"
        '
        'skillFrag1
        '
        Me.skillFrag1.Location = New System.Drawing.Point(144, 324)
        Me.skillFrag1.Name = "skillFrag1"
        Me.skillFrag1.ReadOnly = True
        Me.skillFrag1.Size = New System.Drawing.Size(33, 20)
        Me.skillFrag1.TabIndex = 298
        Me.skillFrag1.TabStop = False
        Me.skillFrag1.Visible = False
        '
        'lblFrag1
        '
        Me.lblFrag1.AutoSize = True
        Me.lblFrag1.Location = New System.Drawing.Point(31, 325)
        Me.lblFrag1.Name = "lblFrag1"
        Me.lblFrag1.Size = New System.Drawing.Size(59, 13)
        Me.lblFrag1.TabIndex = 299
        Me.lblFrag1.Text = "Frag Skill 1"
        Me.lblFrag1.Visible = False
        '
        'costFrag1
        '
        Me.costFrag1.AutoSize = True
        Me.costFrag1.Location = New System.Drawing.Point(121, 325)
        Me.costFrag1.Name = "costFrag1"
        Me.costFrag1.Size = New System.Drawing.Size(13, 13)
        Me.costFrag1.TabIndex = 300
        Me.costFrag1.Text = "0"
        Me.costFrag1.Visible = False
        '
        'skillFrag2
        '
        Me.skillFrag2.Location = New System.Drawing.Point(300, 323)
        Me.skillFrag2.Name = "skillFrag2"
        Me.skillFrag2.ReadOnly = True
        Me.skillFrag2.Size = New System.Drawing.Size(33, 20)
        Me.skillFrag2.TabIndex = 301
        Me.skillFrag2.TabStop = False
        Me.skillFrag2.Visible = False
        '
        'lblFrag2
        '
        Me.lblFrag2.AutoSize = True
        Me.lblFrag2.Location = New System.Drawing.Point(185, 326)
        Me.lblFrag2.Name = "lblFrag2"
        Me.lblFrag2.Size = New System.Drawing.Size(59, 13)
        Me.lblFrag2.TabIndex = 302
        Me.lblFrag2.Text = "Frag Skill 2"
        Me.lblFrag2.Visible = False
        '
        'costFrag2
        '
        Me.costFrag2.AutoSize = True
        Me.costFrag2.Location = New System.Drawing.Point(276, 326)
        Me.costFrag2.Name = "costFrag2"
        Me.costFrag2.Size = New System.Drawing.Size(13, 13)
        Me.costFrag2.TabIndex = 303
        Me.costFrag2.Text = "0"
        Me.costFrag2.Visible = False
        '
        'costFrag6
        '
        Me.costFrag6.AutoSize = True
        Me.costFrag6.Location = New System.Drawing.Point(430, 356)
        Me.costFrag6.Name = "costFrag6"
        Me.costFrag6.Size = New System.Drawing.Size(13, 13)
        Me.costFrag6.TabIndex = 316
        Me.costFrag6.Text = "0"
        Me.costFrag6.Visible = False
        '
        'skillFrag3
        '
        Me.skillFrag3.Location = New System.Drawing.Point(454, 323)
        Me.skillFrag3.Name = "skillFrag3"
        Me.skillFrag3.ReadOnly = True
        Me.skillFrag3.Size = New System.Drawing.Size(33, 20)
        Me.skillFrag3.TabIndex = 304
        Me.skillFrag3.TabStop = False
        Me.skillFrag3.Visible = False
        '
        'costFrag5
        '
        Me.costFrag5.AutoSize = True
        Me.costFrag5.Location = New System.Drawing.Point(277, 356)
        Me.costFrag5.Name = "costFrag5"
        Me.costFrag5.Size = New System.Drawing.Size(13, 13)
        Me.costFrag5.TabIndex = 315
        Me.costFrag5.Text = "0"
        Me.costFrag5.Visible = False
        '
        'lblFrag3
        '
        Me.lblFrag3.AutoSize = True
        Me.lblFrag3.Location = New System.Drawing.Point(339, 326)
        Me.lblFrag3.Name = "lblFrag3"
        Me.lblFrag3.Size = New System.Drawing.Size(59, 13)
        Me.lblFrag3.TabIndex = 305
        Me.lblFrag3.Text = "Frag Skill 3"
        Me.lblFrag3.Visible = False
        '
        'costFrag4
        '
        Me.costFrag4.AutoSize = True
        Me.costFrag4.Location = New System.Drawing.Point(122, 356)
        Me.costFrag4.Name = "costFrag4"
        Me.costFrag4.Size = New System.Drawing.Size(13, 13)
        Me.costFrag4.TabIndex = 314
        Me.costFrag4.Text = "0"
        Me.costFrag4.Visible = False
        '
        'costFrag3
        '
        Me.costFrag3.AutoSize = True
        Me.costFrag3.Location = New System.Drawing.Point(429, 326)
        Me.costFrag3.Name = "costFrag3"
        Me.costFrag3.Size = New System.Drawing.Size(13, 13)
        Me.costFrag3.TabIndex = 306
        Me.costFrag3.Text = "0"
        Me.costFrag3.Visible = False
        '
        'skillLooting
        '
        Me.skillLooting.Location = New System.Drawing.Point(608, 324)
        Me.skillLooting.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.skillLooting.Name = "skillLooting"
        Me.skillLooting.ReadOnly = True
        Me.skillLooting.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.skillLooting.Size = New System.Drawing.Size(33, 20)
        Me.skillLooting.TabIndex = 307
        Me.skillLooting.TabStop = False
        '
        'lblFrag6
        '
        Me.lblFrag6.AutoSize = True
        Me.lblFrag6.Location = New System.Drawing.Point(340, 356)
        Me.lblFrag6.Name = "lblFrag6"
        Me.lblFrag6.Size = New System.Drawing.Size(59, 13)
        Me.lblFrag6.TabIndex = 312
        Me.lblFrag6.Text = "Frag Skill 6"
        Me.lblFrag6.Visible = False
        '
        'lblLooting
        '
        Me.lblLooting.AutoSize = True
        Me.lblLooting.Location = New System.Drawing.Point(493, 326)
        Me.lblLooting.Name = "lblLooting"
        Me.lblLooting.Size = New System.Drawing.Size(42, 13)
        Me.lblLooting.TabIndex = 308
        Me.lblLooting.Text = "Looting"
        '
        'lblFrag5
        '
        Me.lblFrag5.AutoSize = True
        Me.lblFrag5.Location = New System.Drawing.Point(186, 356)
        Me.lblFrag5.Name = "lblFrag5"
        Me.lblFrag5.Size = New System.Drawing.Size(59, 13)
        Me.lblFrag5.TabIndex = 311
        Me.lblFrag5.Text = "Frag Skill 5"
        Me.lblFrag5.Visible = False
        '
        'costLooting
        '
        Me.costLooting.AutoSize = True
        Me.costLooting.Location = New System.Drawing.Point(583, 326)
        Me.costLooting.Name = "costLooting"
        Me.costLooting.Size = New System.Drawing.Size(19, 13)
        Me.costLooting.TabIndex = 309
        Me.costLooting.Text = "15"
        '
        'lblFrag4
        '
        Me.lblFrag4.AutoSize = True
        Me.lblFrag4.Location = New System.Drawing.Point(32, 356)
        Me.lblFrag4.Name = "lblFrag4"
        Me.lblFrag4.Size = New System.Drawing.Size(59, 13)
        Me.lblFrag4.TabIndex = 310
        Me.lblFrag4.Text = "Frag Skill 4"
        Me.lblFrag4.Visible = False
        '
        'lblJob1
        '
        Me.lblJob1.AutoSize = True
        Me.lblJob1.Location = New System.Drawing.Point(29, 151)
        Me.lblJob1.Name = "lblJob1"
        Me.lblJob1.Size = New System.Drawing.Size(55, 13)
        Me.lblJob1.TabIndex = 218
        Me.lblJob1.Text = "Job Skill 1"
        '
        'skillJob1
        '
        Me.skillJob1.Location = New System.Drawing.Point(144, 149)
        Me.skillJob1.Name = "skillJob1"
        Me.skillJob1.ReadOnly = True
        Me.skillJob1.Size = New System.Drawing.Size(33, 20)
        Me.skillJob1.TabIndex = 217
        Me.skillJob1.TabStop = False
        '
        'costJob1
        '
        Me.costJob1.AutoSize = True
        Me.costJob1.Location = New System.Drawing.Point(119, 151)
        Me.costJob1.Name = "costJob1"
        Me.costJob1.Size = New System.Drawing.Size(19, 13)
        Me.costJob1.TabIndex = 219
        Me.costJob1.Text = "30"
        '
        'skillJob2
        '
        Me.skillJob2.Location = New System.Drawing.Point(298, 149)
        Me.skillJob2.Name = "skillJob2"
        Me.skillJob2.ReadOnly = True
        Me.skillJob2.Size = New System.Drawing.Size(33, 20)
        Me.skillJob2.TabIndex = 220
        Me.skillJob2.TabStop = False
        '
        'lblJob2
        '
        Me.lblJob2.AutoSize = True
        Me.lblJob2.Location = New System.Drawing.Point(183, 152)
        Me.lblJob2.Name = "lblJob2"
        Me.lblJob2.Size = New System.Drawing.Size(55, 13)
        Me.lblJob2.TabIndex = 221
        Me.lblJob2.Text = "Job Skill 2"
        '
        'costJob2
        '
        Me.costJob2.AutoSize = True
        Me.costJob2.Location = New System.Drawing.Point(273, 152)
        Me.costJob2.Name = "costJob2"
        Me.costJob2.Size = New System.Drawing.Size(19, 13)
        Me.costJob2.TabIndex = 222
        Me.costJob2.Text = "60"
        '
        'skillJob3
        '
        Me.skillJob3.Location = New System.Drawing.Point(452, 149)
        Me.skillJob3.Name = "skillJob3"
        Me.skillJob3.ReadOnly = True
        Me.skillJob3.Size = New System.Drawing.Size(33, 20)
        Me.skillJob3.TabIndex = 223
        Me.skillJob3.TabStop = False
        '
        'lblJob3
        '
        Me.lblJob3.AutoSize = True
        Me.lblJob3.Location = New System.Drawing.Point(337, 152)
        Me.lblJob3.Name = "lblJob3"
        Me.lblJob3.Size = New System.Drawing.Size(55, 13)
        Me.lblJob3.TabIndex = 224
        Me.lblJob3.Text = "Job Skill 3"
        '
        'costJob3
        '
        Me.costJob3.AutoSize = True
        Me.costJob3.Location = New System.Drawing.Point(427, 152)
        Me.costJob3.Name = "costJob3"
        Me.costJob3.Size = New System.Drawing.Size(19, 13)
        Me.costJob3.TabIndex = 225
        Me.costJob3.Text = "90"
        '
        'skillJob4
        '
        Me.skillJob4.Location = New System.Drawing.Point(606, 150)
        Me.skillJob4.Name = "skillJob4"
        Me.skillJob4.ReadOnly = True
        Me.skillJob4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.skillJob4.Size = New System.Drawing.Size(33, 20)
        Me.skillJob4.TabIndex = 226
        Me.skillJob4.TabStop = False
        '
        'lblJob4
        '
        Me.lblJob4.AutoSize = True
        Me.lblJob4.Location = New System.Drawing.Point(491, 152)
        Me.lblJob4.Name = "lblJob4"
        Me.lblJob4.Size = New System.Drawing.Size(55, 13)
        Me.lblJob4.TabIndex = 227
        Me.lblJob4.Text = "Job Skill 4"
        '
        'costJob4
        '
        Me.costJob4.AutoSize = True
        Me.costJob4.Location = New System.Drawing.Point(581, 152)
        Me.costJob4.Name = "costJob4"
        Me.costJob4.Size = New System.Drawing.Size(25, 13)
        Me.costJob4.TabIndex = 228
        Me.costJob4.Text = "120"
        '
        'skillRacial2
        '
        Me.skillRacial2.Location = New System.Drawing.Point(302, 239)
        Me.skillRacial2.Name = "skillRacial2"
        Me.skillRacial2.ReadOnly = True
        Me.skillRacial2.Size = New System.Drawing.Size(33, 20)
        Me.skillRacial2.TabIndex = 257
        Me.skillRacial2.TabStop = False
        '
        'lblRacial2
        '
        Me.lblRacial2.AutoSize = True
        Me.lblRacial2.Location = New System.Drawing.Point(187, 241)
        Me.lblRacial2.Name = "lblRacial2"
        Me.lblRacial2.Size = New System.Drawing.Size(59, 13)
        Me.lblRacial2.TabIndex = 258
        Me.lblRacial2.Text = "Racial Skill"
        '
        'costRacial2
        '
        Me.costRacial2.AutoSize = True
        Me.costRacial2.Location = New System.Drawing.Point(277, 241)
        Me.costRacial2.Name = "costRacial2"
        Me.costRacial2.Size = New System.Drawing.Size(19, 13)
        Me.costRacial2.TabIndex = 259
        Me.costRacial2.Text = "50"
        '
        'skillBPB
        '
        Me.skillBPB.Location = New System.Drawing.Point(454, 239)
        Me.skillBPB.Name = "skillBPB"
        Me.skillBPB.ReadOnly = True
        Me.skillBPB.Size = New System.Drawing.Size(33, 20)
        Me.skillBPB.TabIndex = 263
        Me.skillBPB.TabStop = False
        '
        'lblBPB
        '
        Me.lblBPB.AutoSize = True
        Me.lblBPB.Location = New System.Drawing.Point(339, 242)
        Me.lblBPB.Name = "lblBPB"
        Me.lblBPB.Size = New System.Drawing.Size(91, 13)
        Me.lblBPB.TabIndex = 264
        Me.lblBPB.Text = "Body Point Bonus"
        '
        'costBPB
        '
        Me.costBPB.AutoSize = True
        Me.costBPB.Location = New System.Drawing.Point(429, 242)
        Me.costBPB.Name = "costBPB"
        Me.costBPB.Size = New System.Drawing.Size(19, 13)
        Me.costBPB.TabIndex = 265
        Me.costBPB.Text = "50"
        '
        'skillStr
        '
        Me.skillStr.Location = New System.Drawing.Point(608, 240)
        Me.skillStr.Name = "skillStr"
        Me.skillStr.ReadOnly = True
        Me.skillStr.Size = New System.Drawing.Size(33, 20)
        Me.skillStr.TabIndex = 266
        Me.skillStr.TabStop = False
        '
        'lblStr
        '
        Me.lblStr.AutoSize = True
        Me.lblStr.Location = New System.Drawing.Point(493, 242)
        Me.lblStr.Name = "lblStr"
        Me.lblStr.Size = New System.Drawing.Size(80, 13)
        Me.lblStr.TabIndex = 267
        Me.lblStr.Text = "Strength Bonus"
        '
        'costStr
        '
        Me.costStr.AutoSize = True
        Me.costStr.Location = New System.Drawing.Point(583, 242)
        Me.costStr.Name = "costStr"
        Me.costStr.Size = New System.Drawing.Size(19, 13)
        Me.costStr.TabIndex = 268
        Me.costStr.Text = "50"
        '
        'skillRacial1
        '
        Me.skillRacial1.Location = New System.Drawing.Point(146, 239)
        Me.skillRacial1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillRacial1.Name = "skillRacial1"
        Me.skillRacial1.ReadOnly = True
        Me.skillRacial1.Size = New System.Drawing.Size(33, 20)
        Me.skillRacial1.TabIndex = 272
        Me.skillRacial1.TabStop = False
        Me.skillRacial1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.skillRacial1.Visible = False
        '
        'lblRacial1
        '
        Me.lblRacial1.AutoSize = True
        Me.lblRacial1.Location = New System.Drawing.Point(31, 241)
        Me.lblRacial1.Name = "lblRacial1"
        Me.lblRacial1.Size = New System.Drawing.Size(59, 13)
        Me.lblRacial1.TabIndex = 273
        Me.lblRacial1.Text = "Racial Skill"
        Me.lblRacial1.Visible = False
        '
        'costRacial1
        '
        Me.costRacial1.AutoSize = True
        Me.costRacial1.Location = New System.Drawing.Point(121, 241)
        Me.costRacial1.Name = "costRacial1"
        Me.costRacial1.Size = New System.Drawing.Size(19, 13)
        Me.costRacial1.TabIndex = 274
        Me.costRacial1.Text = "50"
        Me.costRacial1.Visible = False
        '
        'listRacial
        '
        Me.listRacial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listRacial.FormattingEnabled = True
        Me.listRacial.Items.AddRange(New Object() {"Angels/Demons", "Animals", "Bestial", "Brood", "Constructs", "Draconic", "Dwarves", "Elementals", "Elves", "Fae", "Goblinoids", "Humanoids", "Plants", "Spirits", "Undead", "Vermin"})
        Me.listRacial.Location = New System.Drawing.Point(34, 265)
        Me.listRacial.Name = "listRacial"
        Me.listRacial.Size = New System.Drawing.Size(145, 21)
        Me.listRacial.TabIndex = 275
        Me.listRacial.Visible = False
        '
        'lblBlacksmith
        '
        Me.lblBlacksmith.AutoSize = True
        Me.lblBlacksmith.Location = New System.Drawing.Point(183, 29)
        Me.lblBlacksmith.Name = "lblBlacksmith"
        Me.lblBlacksmith.Size = New System.Drawing.Size(58, 13)
        Me.lblBlacksmith.TabIndex = 26
        Me.lblBlacksmith.Text = "Blacksmith"
        '
        'skillAlchemy
        '
        Me.skillAlchemy.Location = New System.Drawing.Point(144, 26)
        Me.skillAlchemy.Name = "skillAlchemy"
        Me.skillAlchemy.ReadOnly = True
        Me.skillAlchemy.Size = New System.Drawing.Size(33, 20)
        Me.skillAlchemy.TabIndex = 22
        Me.skillAlchemy.TabStop = False
        '
        'lblAlchemy
        '
        Me.lblAlchemy.AutoSize = True
        Me.lblAlchemy.Location = New System.Drawing.Point(29, 28)
        Me.lblAlchemy.Name = "lblAlchemy"
        Me.lblAlchemy.Size = New System.Drawing.Size(47, 13)
        Me.lblAlchemy.TabIndex = 23
        Me.lblAlchemy.Text = "Alchemy"
        '
        'costAlchemy
        '
        Me.costAlchemy.AutoSize = True
        Me.costAlchemy.Location = New System.Drawing.Point(119, 28)
        Me.costAlchemy.Name = "costAlchemy"
        Me.costAlchemy.Size = New System.Drawing.Size(13, 13)
        Me.costAlchemy.TabIndex = 24
        Me.costAlchemy.Text = "0"
        '
        'skillBlacksmith
        '
        Me.skillBlacksmith.Location = New System.Drawing.Point(298, 26)
        Me.skillBlacksmith.Name = "skillBlacksmith"
        Me.skillBlacksmith.ReadOnly = True
        Me.skillBlacksmith.Size = New System.Drawing.Size(33, 20)
        Me.skillBlacksmith.TabIndex = 25
        Me.skillBlacksmith.TabStop = False
        '
        'costBlacksmith
        '
        Me.costBlacksmith.AutoSize = True
        Me.costBlacksmith.Location = New System.Drawing.Point(273, 29)
        Me.costBlacksmith.Name = "costBlacksmith"
        Me.costBlacksmith.Size = New System.Drawing.Size(13, 13)
        Me.costBlacksmith.TabIndex = 27
        Me.costBlacksmith.Text = "0"
        '
        'skillCraft1
        '
        Me.skillCraft1.Location = New System.Drawing.Point(144, 64)
        Me.skillCraft1.Name = "skillCraft1"
        Me.skillCraft1.ReadOnly = True
        Me.skillCraft1.Size = New System.Drawing.Size(33, 20)
        Me.skillCraft1.TabIndex = 28
        Me.skillCraft1.TabStop = False
        '
        'lblCraft1
        '
        Me.lblCraft1.AutoSize = True
        Me.lblCraft1.Location = New System.Drawing.Point(29, 67)
        Me.lblCraft1.Name = "lblCraft1"
        Me.lblCraft1.Size = New System.Drawing.Size(54, 13)
        Me.lblCraft1.TabIndex = 29
        Me.lblCraft1.Text = "Tradesman"
        '
        'costCraft1
        '
        Me.costCraft1.AutoSize = True
        Me.costCraft1.Location = New System.Drawing.Point(119, 67)
        Me.costCraft1.Name = "costCraft1"
        Me.costCraft1.Size = New System.Drawing.Size(13, 13)
        Me.costCraft1.TabIndex = 30
        Me.costCraft1.Text = "0"
        '
        'skillCreateScroll
        '
        Me.skillCreateScroll.Location = New System.Drawing.Point(606, 27)
        Me.skillCreateScroll.Name = "skillCreateScroll"
        Me.skillCreateScroll.ReadOnly = True
        Me.skillCreateScroll.Size = New System.Drawing.Size(33, 20)
        Me.skillCreateScroll.TabIndex = 31
        Me.skillCreateScroll.TabStop = False
        '
        'lblCreateScroll
        '
        Me.lblCreateScroll.AutoSize = True
        Me.lblCreateScroll.Location = New System.Drawing.Point(491, 29)
        Me.lblCreateScroll.Name = "lblCreateScroll"
        Me.lblCreateScroll.Size = New System.Drawing.Size(67, 13)
        Me.lblCreateScroll.TabIndex = 32
        Me.lblCreateScroll.Text = "Create Scroll"
        '
        'costCreateScroll
        '
        Me.costCreateScroll.AutoSize = True
        Me.costCreateScroll.Location = New System.Drawing.Point(581, 29)
        Me.costCreateScroll.Name = "costCreateScroll"
        Me.costCreateScroll.Size = New System.Drawing.Size(13, 13)
        Me.costCreateScroll.TabIndex = 33
        Me.costCreateScroll.Text = "0"
        '
        'skillTrapsmith
        '
        Me.skillTrapsmith.Location = New System.Drawing.Point(452, 27)
        Me.skillTrapsmith.Name = "skillTrapsmith"
        Me.skillTrapsmith.ReadOnly = True
        Me.skillTrapsmith.Size = New System.Drawing.Size(33, 20)
        Me.skillTrapsmith.TabIndex = 34
        Me.skillTrapsmith.TabStop = False
        '
        'lblTrapsmith
        '
        Me.lblTrapsmith.AutoSize = True
        Me.lblTrapsmith.Location = New System.Drawing.Point(339, 29)
        Me.lblTrapsmith.Name = "lblTrapsmith"
        Me.lblTrapsmith.Size = New System.Drawing.Size(53, 13)
        Me.lblTrapsmith.TabIndex = 35
        Me.lblTrapsmith.Text = "Trapsmith"
        '
        'costTrapsmith
        '
        Me.costTrapsmith.AutoSize = True
        Me.costTrapsmith.Location = New System.Drawing.Point(427, 29)
        Me.costTrapsmith.Name = "costTrapsmith"
        Me.costTrapsmith.Size = New System.Drawing.Size(13, 13)
        Me.costTrapsmith.TabIndex = 36
        Me.costTrapsmith.Text = "0"
        '
        'boxFragsTotal
        '
        Me.boxFragsTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.boxFragsTotal.Location = New System.Drawing.Point(171, 286)
        Me.boxFragsTotal.Name = "boxFragsTotal"
        Me.boxFragsTotal.ReadOnly = True
        Me.boxFragsTotal.Size = New System.Drawing.Size(48, 20)
        Me.boxFragsTotal.TabIndex = 318
        Me.boxFragsTotal.TabStop = False
        Me.boxFragsTotal.Visible = False
        '
        'lblFrags
        '
        Me.lblFrags.AutoSize = True
        Me.lblFrags.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrags.Location = New System.Drawing.Point(176, 270)
        Me.lblFrags.Name = "lblFrags"
        Me.lblFrags.Size = New System.Drawing.Size(38, 13)
        Me.lblFrags.TabIndex = 319
        Me.lblFrags.Text = "Frags"
        Me.lblFrags.Visible = False
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.JobRaceProd)
        Me.TabControl.Controls.Add(Me.Scholar)
        Me.TabControl.Controls.Add(Me.Warrior)
        Me.TabControl.Controls.Add(Me.Rogue)
        Me.TabControl.Location = New System.Drawing.Point(220, 10)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(676, 480)
        Me.TabControl.TabIndex = 299
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(439, 496)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(99, 39)
        Me.btnOpenFile.TabIndex = 323
        Me.btnOpenFile.Text = "Open File"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'lblCharClass
        '
        Me.lblCharClass.AutoSize = True
        Me.lblCharClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharClass.Location = New System.Drawing.Point(17, 161)
        Me.lblCharClass.Name = "lblCharClass"
        Me.lblCharClass.Size = New System.Drawing.Size(37, 13)
        Me.lblCharClass.TabIndex = 233
        Me.lblCharClass.Text = "Class"
        '
        'chkVocation
        '
        Me.chkVocation.AutoSize = True
        Me.chkVocation.Location = New System.Drawing.Point(39, 206)
        Me.chkVocation.Name = "chkVocation"
        Me.chkVocation.Size = New System.Drawing.Size(74, 17)
        Me.chkVocation.TabIndex = 326
        Me.chkVocation.Text = "Vocation?"
        Me.chkVocation.UseVisualStyleBackColor = True
        '
        'ddlVocation
        '
        Me.ddlVocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlVocation.FormattingEnabled = True
        Me.ddlVocation.Items.AddRange(New Object() {"Archer", "Battle Mage", "Brew Master", "Stalwart", "Undead Hunter"})
        Me.ddlVocation.Location = New System.Drawing.Point(118, 203)
        Me.ddlVocation.Name = "ddlVocation"
        Me.ddlVocation.Size = New System.Drawing.Size(100, 21)
        Me.ddlVocation.TabIndex = 327
        Me.ddlVocation.Visible = False
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Location = New System.Drawing.Point(246, 540)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(250, 13)
        Me.lblWarning.TabIndex = 329
        Me.lblWarning.Text = "The rulebook is always right in case of discrepancy."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 576)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.ddlVocation)
        Me.Controls.Add(Me.chkVocation)
        Me.Controls.Add(Me.boxFragsTotal)
        Me.Controls.Add(Me.boxSkillBreakdown)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.ddlFragGuild)
        Me.Controls.Add(Me.btnSaveToFile)
        Me.Controls.Add(Me.InBox)
        Me.Controls.Add(Me.lblFrags)
        Me.Controls.Add(Me.btnSaveAsText)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblSkillBreakdown)
        Me.Controls.Add(Me.lblHP)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblFreeCP)
        Me.Controls.Add(Me.lblSpentCP)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.lblBlankets)
        Me.Controls.Add(Me.lblCharClass)
        Me.Controls.Add(Me.lblCharRace)
        Me.Controls.Add(Me.lblCharName)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.boxHP)
        Me.Controls.Add(Me.boxLevel)
        Me.Controls.Add(Me.boxCharName)
        Me.Controls.Add(Me.boxPlayerName)
        Me.Controls.Add(Me.boxFreeCP)
        Me.Controls.Add(Me.boxSpentCP)
        Me.Controls.Add(Me.boxTotalCP)
        Me.Controls.Add(Me.numericBlanketAmt)
        Me.Controls.Add(Me.ddlFragCharRace)
        Me.Controls.Add(Me.ddlCharJob)
        Me.Controls.Add(Me.ddlCharRace)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Underworld Character Builder 5.4.11.2b"
        CType(Me.numericBlanketAmt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Rogue.ResumeLayout(False)
        Me.Rogue.PerformLayout()
        CType(Me.skillGarrote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillLocksmith, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillDodge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillCritSpecific, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillCritGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillVitalBlow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillExecute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillExecuteMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Warrior.ResumeLayout(False)
        Me.Warrior.PerformLayout()
        CType(Me.skillSimpleProf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillFlorentine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillFlurryOfBlows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillHeavyArmour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSelfMut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillShield, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillMedProf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillLargeProf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpecGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpecSpecific, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillExoticProf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSlayParry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSlayParryMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillAmbidexterity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillWeaponRefocus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Scholar.ResumeLayout(False)
        Me.Scholar.PerformLayout()
        CType(Me.skillAdvRitual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillPhysician, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillAnatomy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillMysticism, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillDemonAngelArts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillEleAttunement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillFirstAid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillNecroArts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillReadAndWrite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillReadMagic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillReadMagicAvd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillReadMagicRitual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSphere1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSphere2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSphere3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpellRitual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpell1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpell2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpell3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpell4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpell5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpell9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpell8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpell7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpell6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JobRaceProd.ResumeLayout(False)
        Me.JobRaceProd.PerformLayout()
        CType(Me.skillSpellVersa1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpellVersa2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpellVersa3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpellVersa4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpellVersa5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpellVersa9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpellVersa8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpellVersa7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillSpellVersa6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillHeavyDrinker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillFrag6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillFrag5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillFrag4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillCraft4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillcraft3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillCraft2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillFrag1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillFrag2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillFrag3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillLooting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillJob1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillJob2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillJob3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillJob4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillRacial2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillBPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillStr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillRacial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillAlchemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillBlacksmith, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillCraft1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillCreateScroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skillTrapsmith, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ddlCharRace As System.Windows.Forms.ComboBox
	Friend WithEvents ddlCharJob As System.Windows.Forms.ComboBox
	Friend WithEvents ddlFragCharRace As System.Windows.Forms.ComboBox
	Friend WithEvents boxSkillBreakdown As System.Windows.Forms.TextBox
	Friend WithEvents numericBlanketAmt As System.Windows.Forms.NumericUpDown
	Friend WithEvents boxTotalCP As System.Windows.Forms.TextBox
	Friend WithEvents boxSpentCP As System.Windows.Forms.TextBox
	Friend WithEvents boxFreeCP As System.Windows.Forms.TextBox
	Friend WithEvents boxPlayerName As System.Windows.Forms.TextBox
	Friend WithEvents boxCharName As System.Windows.Forms.TextBox
	Friend WithEvents boxLevel As System.Windows.Forms.TextBox
	Friend WithEvents boxHP As System.Windows.Forms.TextBox
	Friend WithEvents lblPlayerName As System.Windows.Forms.Label
	Friend WithEvents lblCharName As System.Windows.Forms.Label
	Friend WithEvents lblCharRace As System.Windows.Forms.Label
	Friend WithEvents lblBlankets As System.Windows.Forms.Label
	Friend WithEvents lblCP As System.Windows.Forms.Label
	Friend WithEvents lblSpentCP As System.Windows.Forms.Label
	Friend WithEvents lblFreeCP As System.Windows.Forms.Label
	Friend WithEvents lblLevel As System.Windows.Forms.Label
	Friend WithEvents lblHP As System.Windows.Forms.Label
	Friend WithEvents lblSkillBreakdown As System.Windows.Forms.Label
	Friend WithEvents btnReset As System.Windows.Forms.Button
	Friend WithEvents btnSaveAsText As System.Windows.Forms.Button
	Friend WithEvents InBox As System.Windows.Forms.ListBox
	Friend WithEvents btnSaveToFile As System.Windows.Forms.Button
	Friend WithEvents ddlFragGuild As System.Windows.Forms.ComboBox
	Friend WithEvents Rogue As System.Windows.Forms.TabPage
	Friend WithEvents lblExecute As System.Windows.Forms.Label
	Friend WithEvents skillGarrote As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblGarrote As System.Windows.Forms.Label
	Friend WithEvents costGarrote As System.Windows.Forms.Label
	Friend WithEvents skillLocksmith As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblLocksmith As System.Windows.Forms.Label
	Friend WithEvents costLocksmith As System.Windows.Forms.Label
	Friend WithEvents skillSap As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblSap As System.Windows.Forms.Label
	Friend WithEvents costSap As System.Windows.Forms.Label
	Friend WithEvents skillDodge As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblDodge As System.Windows.Forms.Label
	Friend WithEvents costDodge As System.Windows.Forms.Label
	Friend WithEvents skillCritSpecific As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCritSpecific As System.Windows.Forms.Label
	Friend WithEvents costCritSpecific As System.Windows.Forms.Label
	Friend WithEvents ddlCritSpecificWeapon As System.Windows.Forms.ComboBox
	Friend WithEvents skillCritGroup As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCritGroup As System.Windows.Forms.Label
	Friend WithEvents costCritGroup As System.Windows.Forms.Label
	Friend WithEvents ddlCritGroup As System.Windows.Forms.ComboBox
	Friend WithEvents skillVitalBlow As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblVitalBlow As System.Windows.Forms.Label
	Friend WithEvents costVitalBlow As System.Windows.Forms.Label
	Friend WithEvents skillExecute As System.Windows.Forms.NumericUpDown
	Friend WithEvents costExecute As System.Windows.Forms.Label
	Friend WithEvents ddlExecute As System.Windows.Forms.ComboBox
	Friend WithEvents skillExecuteMaster As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblExecuteMaster As System.Windows.Forms.Label
	Friend WithEvents costExecuteMaster As System.Windows.Forms.Label
	Friend WithEvents ddlExecuteMaster As System.Windows.Forms.ComboBox
	Friend WithEvents Warrior As System.Windows.Forms.TabPage
	Friend WithEvents lblSlayParry As System.Windows.Forms.Label
	Friend WithEvents lblAmbidexterity As System.Windows.Forms.Label
	Friend WithEvents skillFlorentine As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblFlorentine As System.Windows.Forms.Label
	Friend WithEvents costFlorentine As System.Windows.Forms.Label
	Friend WithEvents skillFlurryOfBlows As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblFlurryofBlows As System.Windows.Forms.Label
	Friend WithEvents costFlurryOfBlows As System.Windows.Forms.Label
	Friend WithEvents skillHeavyArmour As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblHeavyArmour As System.Windows.Forms.Label
	Friend WithEvents costHeavyArmour As System.Windows.Forms.Label
	Friend WithEvents skillSelfMut As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblSelfMut As System.Windows.Forms.Label
	Friend WithEvents costSelfMut As System.Windows.Forms.Label
	Friend WithEvents skillShield As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblShield As System.Windows.Forms.Label
	Friend WithEvents costShield As System.Windows.Forms.Label
	Friend WithEvents skillMedProf As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblMedProf As System.Windows.Forms.Label
	Friend WithEvents costMedProf As System.Windows.Forms.Label
	Friend WithEvents skillLargeProf As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblLargeProf As System.Windows.Forms.Label
	Friend WithEvents costLargeProf As System.Windows.Forms.Label
	Friend WithEvents skillSpecGroup As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblSpecGroup As System.Windows.Forms.Label
	Friend WithEvents costSpecGroup As System.Windows.Forms.Label
	Friend WithEvents skillSpecSpecific As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblSpecSpecific As System.Windows.Forms.Label
	Friend WithEvents costSpecSpecific As System.Windows.Forms.Label
	Friend WithEvents skillExoticProf As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblExoticProf As System.Windows.Forms.Label
	Friend WithEvents costExoticProf As System.Windows.Forms.Label
	Friend WithEvents ddlExoticWeapon As System.Windows.Forms.ComboBox
	Friend WithEvents ddlSpecGroup As System.Windows.Forms.ComboBox
	Friend WithEvents ddlSpecSpecific As System.Windows.Forms.ComboBox
	Friend WithEvents skillSlayParry As System.Windows.Forms.NumericUpDown
	Friend WithEvents costSlayParry As System.Windows.Forms.Label
	Friend WithEvents ddlSlayParryWeapon As System.Windows.Forms.ComboBox
	Friend WithEvents skillSlayParryMaster As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblSlayParryMaster As System.Windows.Forms.Label
	Friend WithEvents costSlayParryMaster As System.Windows.Forms.Label
	Friend WithEvents ddlSlayParryMasterWeapon As System.Windows.Forms.ComboBox
	Friend WithEvents costAmbidexterity As System.Windows.Forms.Label
	Friend WithEvents skillAmbidexterity As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillWeaponRefocus As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblWeaponRefocus As System.Windows.Forms.Label
	Friend WithEvents costWeaponRefocus As System.Windows.Forms.Label
	Friend WithEvents Scholar As System.Windows.Forms.TabPage
	Friend WithEvents skillPhysician As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillAnatomy As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblAnatomy As System.Windows.Forms.Label
	Friend WithEvents costAnatomy As System.Windows.Forms.Label
	Friend WithEvents skillMysticism As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblMysticism As System.Windows.Forms.Label
	Friend WithEvents costMysticism As System.Windows.Forms.Label
	Friend WithEvents skillDemonAngelArts As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblDemonAngelArts As System.Windows.Forms.Label
	Friend WithEvents costDemonAngelArts As System.Windows.Forms.Label
	Friend WithEvents skillEleAttunement As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblEleAttunement As System.Windows.Forms.Label
	Friend WithEvents costEleAttunement As System.Windows.Forms.Label
	Friend WithEvents skillFirstAid As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblFirstAid As System.Windows.Forms.Label
	Friend WithEvents costFirstAid As System.Windows.Forms.Label
	Friend WithEvents skillNecroArts As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblNecroArts As System.Windows.Forms.Label
	Friend WithEvents costNecroArts As System.Windows.Forms.Label
	Friend WithEvents lblPhysician As System.Windows.Forms.Label
	Friend WithEvents costPhysician As System.Windows.Forms.Label
	Friend WithEvents skillReadAndWrite As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblReadAndWrite As System.Windows.Forms.Label
	Friend WithEvents costReadAndWrite As System.Windows.Forms.Label
	Friend WithEvents costSpellRitual As System.Windows.Forms.Label
	Friend WithEvents skillReadMagic As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblReadMagic As System.Windows.Forms.Label
	Friend WithEvents costReadMagic As System.Windows.Forms.Label
	Friend WithEvents skillReadMagicAvd As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblReadMagicAvd As System.Windows.Forms.Label
	Friend WithEvents costReadMagicAvd As System.Windows.Forms.Label
	Friend WithEvents lblRitual As System.Windows.Forms.Label
	Friend WithEvents skillReadMagicRitual As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblSpellLevel9 As System.Windows.Forms.Label
	Friend WithEvents lblReadMagicRitual As System.Windows.Forms.Label
	Friend WithEvents lblSpellLevel8 As System.Windows.Forms.Label
	Friend WithEvents costReadMagicRitual As System.Windows.Forms.Label
	Friend WithEvents lblSpellLevel7 As System.Windows.Forms.Label
	Friend WithEvents skillSphere1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblSpellLevel6 As System.Windows.Forms.Label
	Friend WithEvents lblSphere1 As System.Windows.Forms.Label
	Friend WithEvents lblSpellLevel5 As System.Windows.Forms.Label
	Friend WithEvents costSphere1 As System.Windows.Forms.Label
	Friend WithEvents lblSpellLevel4 As System.Windows.Forms.Label
	Friend WithEvents skillSphere2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblSpellLevel3 As System.Windows.Forms.Label
	Friend WithEvents lblSphere2 As System.Windows.Forms.Label
	Friend WithEvents lblSpellLevel2 As System.Windows.Forms.Label
	Friend WithEvents costSphere2 As System.Windows.Forms.Label
	Friend WithEvents lblSpellLevel1 As System.Windows.Forms.Label
	Friend WithEvents skillSphere3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblSphere3 As System.Windows.Forms.Label
	Friend WithEvents costSphere3 As System.Windows.Forms.Label
	Friend WithEvents ddlSphere1 As System.Windows.Forms.ComboBox
	Friend WithEvents ddlSphere2 As System.Windows.Forms.ComboBox
	Friend WithEvents ddlSphere3 As System.Windows.Forms.ComboBox
	Friend WithEvents skillSpellRitual As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillSpell1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillSpell2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillSpell3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillSpell4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillSpell5 As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillSpell9 As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillSpell8 As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillSpell7 As System.Windows.Forms.NumericUpDown
	Friend WithEvents skillSpell6 As System.Windows.Forms.NumericUpDown
	Friend WithEvents CostRitualCircle As System.Windows.Forms.Label
	Friend WithEvents costSpell1 As System.Windows.Forms.Label
	Friend WithEvents costSpell2 As System.Windows.Forms.Label
	Friend WithEvents costSpell3 As System.Windows.Forms.Label
	Friend WithEvents costSpell4 As System.Windows.Forms.Label
	Friend WithEvents costSpell5 As System.Windows.Forms.Label
	Friend WithEvents costSpell6 As System.Windows.Forms.Label
	Friend WithEvents costSpell7 As System.Windows.Forms.Label
	Friend WithEvents costSpell8 As System.Windows.Forms.Label
	Friend WithEvents costSpell9 As System.Windows.Forms.Label
	Friend WithEvents JobRaceProd As System.Windows.Forms.TabPage
	Friend WithEvents skillFrag1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblFrag1 As System.Windows.Forms.Label
	Friend WithEvents costFrag1 As System.Windows.Forms.Label
	Friend WithEvents lblFrags As System.Windows.Forms.Label
	Friend WithEvents skillFrag2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents boxFragsTotal As System.Windows.Forms.TextBox
	Friend WithEvents lblFrag2 As System.Windows.Forms.Label
	Friend WithEvents costFrag2 As System.Windows.Forms.Label
	Friend WithEvents costFrag6 As System.Windows.Forms.Label
	Friend WithEvents skillFrag3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents costFrag5 As System.Windows.Forms.Label
	Friend WithEvents lblFrag3 As System.Windows.Forms.Label
	Friend WithEvents costFrag4 As System.Windows.Forms.Label
	Friend WithEvents costFrag3 As System.Windows.Forms.Label
	Friend WithEvents skillLooting As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblFrag6 As System.Windows.Forms.Label
	Friend WithEvents lblLooting As System.Windows.Forms.Label
	Friend WithEvents lblFrag5 As System.Windows.Forms.Label
	Friend WithEvents costLooting As System.Windows.Forms.Label
	Friend WithEvents lblFrag4 As System.Windows.Forms.Label
	Friend WithEvents lblJob1 As System.Windows.Forms.Label
	Friend WithEvents skillJob1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents costJob1 As System.Windows.Forms.Label
	Friend WithEvents skillJob2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblJob2 As System.Windows.Forms.Label
	Friend WithEvents costJob2 As System.Windows.Forms.Label
	Friend WithEvents skillJob3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblJob3 As System.Windows.Forms.Label
	Friend WithEvents costJob3 As System.Windows.Forms.Label
	Friend WithEvents skillJob4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblJob4 As System.Windows.Forms.Label
	Friend WithEvents costJob4 As System.Windows.Forms.Label
	Friend WithEvents skillRacial2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblRacial2 As System.Windows.Forms.Label
	Friend WithEvents costRacial2 As System.Windows.Forms.Label
	Friend WithEvents skillBPB As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblBPB As System.Windows.Forms.Label
	Friend WithEvents costBPB As System.Windows.Forms.Label
	Friend WithEvents skillStr As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblStr As System.Windows.Forms.Label
	Friend WithEvents costStr As System.Windows.Forms.Label
	Friend WithEvents skillRacial1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblRacial1 As System.Windows.Forms.Label
	Friend WithEvents costRacial1 As System.Windows.Forms.Label
	Friend WithEvents listRacial As System.Windows.Forms.ComboBox
	Friend WithEvents lblBlacksmith As System.Windows.Forms.Label
	Friend WithEvents skillAlchemy As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblAlchemy As System.Windows.Forms.Label
	Friend WithEvents costAlchemy As System.Windows.Forms.Label
	Friend WithEvents skillBlacksmith As System.Windows.Forms.NumericUpDown
	Friend WithEvents costBlacksmith As System.Windows.Forms.Label
	Friend WithEvents skillCraft1 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCraft1 As System.Windows.Forms.Label
	Friend WithEvents costCraft1 As System.Windows.Forms.Label
	Friend WithEvents skillCreateScroll As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCreateScroll As System.Windows.Forms.Label
	Friend WithEvents costCreateScroll As System.Windows.Forms.Label
	Friend WithEvents skillTrapsmith As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTrapsmith As System.Windows.Forms.Label
	Friend WithEvents costTrapsmith As System.Windows.Forms.Label
	Friend WithEvents TabControl As System.Windows.Forms.TabControl
	Friend WithEvents lblProd As System.Windows.Forms.Label
	Friend WithEvents Label29 As System.Windows.Forms.Label
	Friend WithEvents ddlEleAttunement1 As System.Windows.Forms.ComboBox
	Friend WithEvents ddlEleAttunement4 As System.Windows.Forms.ComboBox
	Friend WithEvents ddlEleAttunement3 As System.Windows.Forms.ComboBox
	Friend WithEvents ddlEleAttunement2 As System.Windows.Forms.ComboBox
	Friend WithEvents lblRaceSkills As System.Windows.Forms.Label
	Friend WithEvents lblJob As System.Windows.Forms.Label
	Friend WithEvents Label31 As System.Windows.Forms.Label
	Friend WithEvents lblSpellSlots As System.Windows.Forms.Label
	Friend WithEvents costFavoured As System.Windows.Forms.Label
	Friend WithEvents FavouredCheck As System.Windows.Forms.CheckBox
	Friend WithEvents B64b As System.Windows.Forms.TextBox
	Friend WithEvents B64a As System.Windows.Forms.TextBox
	Friend WithEvents btnOpenFile As System.Windows.Forms.Button
	Friend WithEvents skillCraft4 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCraft4 As System.Windows.Forms.Label
	Friend WithEvents costCraft4 As System.Windows.Forms.Label
	Friend WithEvents skillcraft3 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCraft3 As System.Windows.Forms.Label
	Friend WithEvents costCraft3 As System.Windows.Forms.Label
	Friend WithEvents skillCraft2 As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblCraft2 As System.Windows.Forms.Label
	Friend WithEvents costCraft2 As System.Windows.Forms.Label
	Friend WithEvents boxCraft4 As System.Windows.Forms.TextBox
	Friend WithEvents boxCraft3 As System.Windows.Forms.TextBox
	Friend WithEvents boxCraft2 As System.Windows.Forms.TextBox
	Friend WithEvents boxCraft1 As System.Windows.Forms.TextBox
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents skillSimpleProf As NumericUpDown
	Friend WithEvents lblSimpleProf As Label
	Friend WithEvents costSimpleProf As Label
	Friend WithEvents lblCharClass As Label
	Friend WithEvents skillFrag6 As NumericUpDown
	Friend WithEvents skillFrag5 As NumericUpDown
	Friend WithEvents skillFrag4 As NumericUpDown
	Friend WithEvents skillHeavyDrinker As NumericUpDown
	Friend WithEvents costHeavyDrinker As Label
	Friend WithEvents lblHeavyDrinker As Label
	Friend WithEvents lblSpellVersa9 As Label
	Friend WithEvents lblSpellVersa8 As Label
	Friend WithEvents lblSpellVersa7 As Label
	Friend WithEvents lblSpellVersa6 As Label
	Friend WithEvents lblSpellVersa5 As Label
	Friend WithEvents lblSpellVersa4 As Label
	Friend WithEvents lblSpellVersa3 As Label
	Friend WithEvents lblSpellVersa2 As Label
	Friend WithEvents lblSpellVersa1 As Label
	Friend WithEvents skillSpellVersa1 As NumericUpDown
	Friend WithEvents skillSpellVersa2 As NumericUpDown
	Friend WithEvents skillSpellVersa3 As NumericUpDown
	Friend WithEvents skillSpellVersa4 As NumericUpDown
	Friend WithEvents skillSpellVersa5 As NumericUpDown
	Friend WithEvents skillSpellVersa9 As NumericUpDown
	Friend WithEvents skillSpellVersa8 As NumericUpDown
	Friend WithEvents skillSpellVersa7 As NumericUpDown
	Friend WithEvents skillSpellVersa6 As NumericUpDown
	Friend WithEvents costSpellVersa1 As Label
	Friend WithEvents costSpellVersa2 As Label
	Friend WithEvents costSpellVersa3 As Label
	Friend WithEvents costSpellVersa4 As Label
	Friend WithEvents costSpellVersa5 As Label
	Friend WithEvents costSpellVersa6 As Label
	Friend WithEvents costSpellVersa7 As Label
	Friend WithEvents costSpellVersa8 As Label
	Friend WithEvents costSpellVersa9 As Label
	Friend WithEvents lblSpellVersa As Label
	Friend WithEvents chkVocation As CheckBox
	Friend WithEvents ddlVocation As ComboBox
    Friend WithEvents lblWarning As Label
    Friend WithEvents costAdvRitual As Label
    Friend WithEvents lblAdvRitual As Label
    Friend WithEvents skillAdvRitual As NumericUpDown
    Friend WithEvents lblPyramid As Label
    Friend WithEvents lblPyramidOrSpinners As Label
    Friend WithEvents ddlPyramid As ComboBox
End Class
