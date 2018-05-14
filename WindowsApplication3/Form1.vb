Option Explicit On
Public Class Form1

#Region "Variables"
	Dim BlanketCP As Integer
	Dim RaceCP As Integer
	Dim InitialCP As Integer
	Dim TotalCP As Integer
	Dim Level As Integer = 1
	Dim SpentCP As Integer
	Dim FreeCP As Integer
	Dim SpentSF As Integer = 0
	Dim Race As Integer = 0
	Dim Job As Integer = 1000
	Dim FirstRun As Boolean = True
	Dim SPhere700 As Boolean = False
	Dim SPhere701 As Boolean = False
	Dim SPhere702 As Boolean = False
	Dim SPhere703 As Boolean = False
	Dim SPhere704 As Boolean = False
	Dim SPhere705 As Boolean = False
	Dim JobHP As Double
	Dim BOnusHP As Integer = 0
	Dim TotalHP As Integer
	Dim PlayerName As String = String.Empty
	Dim CharacterName As String = String.Empty
	Dim RaceName As String = String.Empty
	Dim JobName As String = String.Empty
	Dim NoStr As Boolean
    Dim NoBod As Boolean
    Dim OpenSave As Boolean
#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Level = 1
		DependCheck()
		ddlSphere1.Enabled = False
		ddlSphere2.Enabled = False
		ddlSphere3.Enabled = False
		ddlFragCharRace.Visible = False
		NoBod = False
		NoStr = False
		boxTotalCP.Text = 150
		boxSpentCP.Text = 0
		boxFreeCP.Text = 150
		numericBlanketAmt.Value = 0
		boxLevel.Text = 1
		RaceCP = 0
		BlanketCP = 0
		InitialCP = 150
	End Sub

#Region "Utility Methods"
	Private Sub Recalc()
		If FirstRun = True Then
			FirstRun = False
			Production()
			Circles()
			ScholarSkills()
			WarriorSkills()
            RogueSkills()
        End If
		SetJobSkills()
		DependCheck()
		SPhere700 = False
		SPhere701 = False
		SPhere702 = False
		SPhere703 = False
		SPhere704 = False
		Production()
		Circles()
		ScholarSkills()
		WarriorSkills()
		RogueSkills()
		FragSkills()
		Costs()

		TotalCP = BlanketCP + RaceCP + InitialCP
		FreeCP = TotalCP - SpentCP
		boxTotalCP.Text = TotalCP
		boxFragsTotal.Text = SpentSF
		If FreeCP < 0 Then boxFreeCP.BackColor = Color.Red Else boxFreeCP.BackColor = Color.WhiteSmoke
		boxFreeCP.Text = FreeCP
		boxSpentCP.Text = SpentCP
		skillAlchemy.Enabled = True
		skillBlacksmith.Enabled = True
		skillCraft1.Enabled = True
		skillCreateScroll.Enabled = True
		skillTrapsmith.Enabled = True

		skillSpell1.Enabled = True
		skillSpell2.Enabled = True
		skillSpell3.Enabled = True
		skillSpell4.Enabled = True
		skillSpell5.Enabled = True
		skillSpell6.Enabled = True
		skillSpell7.Enabled = True
		skillSpell8.Enabled = True
		skillSpell9.Enabled = True
		skillSpellRitual.Enabled = True

		skillAnatomy.Enabled = True
		skillMysticism.Enabled = True
		skillDemonAngelArts.Enabled = True
		skillEleAttunement.Enabled = True
		skillFirstAid.Enabled = True
		skillNecroArts.Enabled = True
		skillPhysician.Enabled = True
		skillReadAndWrite.Enabled = True
		skillReadMagic.Enabled = True
		skillReadMagicAvd.Enabled = True
		skillReadMagicRitual.Enabled = True
		skillSpellRitual.Enabled = True
		skillSphere1.Enabled = True
		skillSphere2.Enabled = True
        skillSphere3.Enabled = True
        ddlPyramid.Enabled = True

        skillAmbidexterity.Enabled = True
		skillFlorentine.Enabled = True
		skillFlurryOfBlows.Enabled = True
		skillHeavyArmour.Enabled = True
		skillSelfMut.Enabled = True
		skillShield.Enabled = True
		skillSlayParry.Enabled = True
		skillSlayParryMaster.Enabled = True
		skillSpecGroup.Enabled = True
		skillSpecSpecific.Enabled = True
		skillSimpleProf.Enabled = True
		skillMedProf.Enabled = True
		skillLargeProf.Enabled = True
		skillExoticProf.Enabled = True
		skillWeaponRefocus.Enabled = True

		skillCritGroup.Enabled = True
		skillDodge.Enabled = True
		skillExecute.Enabled = True
		skillExecuteMaster.Enabled = True
        skillGarrote.Enabled = True
        skillSap.Enabled = True
		skillVitalBlow.Enabled = True
		If Race = 805 Then
			skillMedProf.Enabled = False
			skillLargeProf.Enabled = False
		End If
		skillBPB.Enabled = True
		skillStr.Enabled = True
		RaceBonus()
		SphereSets()
		SetSpheres()
		WeaponLocks()
		SkillListBuild()
		DependCheck()
		HPTotal()
		BuildSpecGroupList()
		BuildSpecSpecificList()
		BuildSlayParryList()
		BuildSlayParryMasterList()
		BuildCritList()
		BuildCritMasterList()
		BuildExecuteList()
		BuildExecuteMasterList()

	End Sub

	Public Function HPTotal()
		Select Case Job
			Case 1000 To 1002
				JobHP = Level * 2 + 4
			Case 1003 To 1005
				JobHP = Level + 3
			Case 1006 To 1008
				If Level = 1 Then JobHP = 3 Else
				JobHP = 3
				For i = 1 To (Level - 1)
					If Int(JobHP) Mod 2 Then JobHP = JobHP + 1 Else JobHP = JobHP + 0.5
				Next i
				JobHP = Int(JobHP)
			Case 1009 To 1010
				JobHP = Level * 2 + 4
			Case 1011 To 1013
				If Level = 1 Then JobHP = 3 Else
				JobHP = 3
				For i = 1 To (Level - 1)
					If Int(JobHP) Mod 2 Then JobHP = JobHP + 1 Else JobHP = JobHP + 0.5
				Next i
				JobHP = Int(JobHP)
		End Select

		If Race = 819 Then
            BOnusHP = Level * 2 + 5
        ElseIf Race = 808 Then
			BOnusHP = skillRacial2.Value * 5
		Else : BOnusHP = skillBPB.Value * 5
		End If
		HPTotal = BOnusHP + JobHP
		boxHP.Text = HPTotal
	End Function
	Private Sub Costs()
		SpentSF = 0
		SpentCP = 0
		SpentCP = SpentCP + Int(costAlchemy.Text) * skillAlchemy.Value
		SpentCP = SpentCP + Int(costBlacksmith.Text) * skillBlacksmith.Value
        SpentCP = SpentCP + Int(costCraft1.Text) * skillCraft1.Value
        SpentCP = SpentCP + Int(costCreateScroll.Text) * skillCreateScroll.Value
		SpentCP = SpentCP + Int(costTrapsmith.Text) * skillTrapsmith.Value

		SpentCP = SpentCP + Int(costAnatomy.Text) * skillAnatomy.Value
		SpentCP = SpentCP + Int(costMysticism.Text) * skillMysticism.Value
		SpentCP = SpentCP + Int(costDemonAngelArts.Text) * skillDemonAngelArts.Value
		SpentCP = SpentCP + Int(costEleAttunement.Text) * skillEleAttunement.Value
		SpentCP = SpentCP + Int(costFirstAid.Text) * skillFirstAid.Value
		SpentCP = SpentCP + Int(costNecroArts.Text) * skillNecroArts.Value
		SpentCP = SpentCP + Int(costPhysician.Text) * skillPhysician.Value
		SpentCP = SpentCP + Int(costReadAndWrite.Text) * skillReadAndWrite.Value
		SpentCP = SpentCP + Int(costReadMagic.Text) * skillReadMagic.Value
		SpentCP = SpentCP + Int(costReadMagicAvd.Text) * skillReadMagicAvd.Value
		SpentCP = SpentCP + Int(costReadMagicRitual.Text) * skillReadMagicRitual.Value
		SpentCP = SpentCP + Int(costSpell1.Text) * skillSpell1.Value
		SpentCP = SpentCP + Int(costSpell2.Text) * skillSpell2.Value
		SpentCP = SpentCP + Int(costSpell3.Text) * skillSpell3.Value
		SpentCP = SpentCP + Int(costSpell4.Text) * skillSpell4.Value
		SpentCP = SpentCP + Int(costSpell5.Text) * skillSpell5.Value
		SpentCP = SpentCP + Int(costSpell6.Text) * skillSpell6.Value
		SpentCP = SpentCP + Int(costSpell7.Text) * skillSpell7.Value
		SpentCP = SpentCP + Int(costSpell8.Text) * skillSpell8.Value
		SpentCP = SpentCP + Int(costSpell9.Text) * skillSpell9.Value
		Select Case skillSpellRitual.Value
			Case 1
				SpentCP = SpentCP + Int(CostRitualCircle.Text) * skillSpellRitual.Value
			Case 2
				SpentCP = SpentCP + Int(CostRitualCircle.Text) * 3
			Case 3
				SpentCP = SpentCP + Int(CostRitualCircle.Text) * 6
			Case 4
				SpentCP = SpentCP + Int(CostRitualCircle.Text) * 10
			Case 5
				SpentCP = SpentCP + Int(CostRitualCircle.Text) * 15
			Case 6
				SpentCP = SpentCP + Int(CostRitualCircle.Text) * 21
			Case 7
				SpentCP = SpentCP + Int(CostRitualCircle.Text) * 28
			Case 8
				SpentCP = SpentCP + Int(CostRitualCircle.Text) * 36
			Case 9
				SpentCP = SpentCP + Int(CostRitualCircle.Text) * 45
			Case 10
				SpentCP = SpentCP + Int(CostRitualCircle.Text) * 55

		End Select

		SpentCP = SpentCP + Int(costSphere1.Text) * skillSphere1.Value
		SpentCP = SpentCP + Int(costSphere2.Text) * skillSphere2.Value
        SpentCP = SpentCP + Int(costSphere3.Text) * skillSphere3.Value
        SpentCP = SpentCP + Int(costAdvRitual.Text) * skillAdvRitual.Value

        SpentCP = SpentCP + Int(costAmbidexterity.Text) * skillAmbidexterity.Value
		SpentCP = SpentCP + Int(costFlorentine.Text) * skillFlorentine.Value
		SpentCP = SpentCP + Int(costFlurryOfBlows.Text) * skillFlurryOfBlows.Value
		SpentCP = SpentCP + Int(costHeavyArmour.Text) * skillHeavyArmour.Value
		SpentCP = SpentCP + Int(costSelfMut.Text) * skillSelfMut.Value
		SpentCP = SpentCP + Int(costShield.Text) * skillShield.Value
		SpentCP = SpentCP + Int(costSlayParry.Text) * skillSlayParry.Value
		SpentCP = SpentCP + Int(costSlayParryMaster.Text) * skillSlayParryMaster.Value
		SpentCP = SpentCP + Int(costSpecGroup.Text) * skillSpecGroup.Value
		SpentCP = SpentCP + Int(costSpecSpecific.Text) * skillSpecSpecific.Value
		SpentCP = SpentCP + Int(costSimpleProf.Text) * skillSimpleProf.Value
		SpentCP = SpentCP + Int(costMedProf.Text) * skillMedProf.Value
		SpentCP = SpentCP + Int(costLargeProf.Text) * skillLargeProf.Value
		SpentCP = SpentCP + Int(costExoticProf.Text) * skillExoticProf.Value
		SpentCP = SpentCP + Int(costWeaponRefocus.Text) * skillWeaponRefocus.Value


		SpentCP = SpentCP + Int(costCritSpecific.Text) * skillCritSpecific.Value
		SpentCP = SpentCP + Int(costCritGroup.Text) * skillCritGroup.Value
		SpentCP = SpentCP + Int(costDodge.Text) * skillDodge.Value
		SpentCP = SpentCP + Int(costExecute.Text) * skillExecute.Value
		SpentCP = SpentCP + Int(costExecuteMaster.Text) * skillExecuteMaster.Value
        SpentCP = SpentCP + Int(costGarrote.Text) * skillGarrote.Value
        SpentCP = SpentCP + Int(costSap.Text) * skillSap.Value
		SpentCP = SpentCP + Int(costVitalBlow.Text) * skillVitalBlow.Value

		costJob1.Text = 30
		costJob2.Text = 60
		costJob3.Text = 90
		costJob4.Text = 120
		costRacial2.Text = 50
		costBPB.Text = 50
		costStr.Text = 50
		SpentCP = SpentCP + Int(costJob1.Text) * skillJob1.Value
		SpentCP = SpentCP + Int(costJob2.Text) * skillJob2.Value
		SpentCP = SpentCP + Int(costJob3.Text) * skillJob3.Value
		SpentCP = SpentCP + Int(costJob4.Text) * skillJob4.Value

		SpentCP = SpentCP + Int(costRacial2.Text) * skillRacial2.Value
		SpentCP = SpentCP + Int(costBPB.Text) * skillBPB.Value
		SpentCP = SpentCP + Int(costStr.Text) * skillStr.Value
        If Race = 821 Then SpentCP = SpentCP + (Int(costRacialAuto.Text)) * (skillRacialAuto.Value - 1)

        SpentCP = SpentCP + Int(costFrag1.Text) * skillFrag1.Value
		SpentCP = SpentCP + Int(costFrag2.Text) * skillFrag2.Value
		SpentCP = SpentCP + Int(costFrag3.Text) * skillFrag3.Value
		SpentCP = SpentCP + Int(costFrag4.Text) * skillFrag4.Value
		SpentCP = SpentCP + Int(costFrag5.Text) * skillFrag5.Value
		SpentCP = SpentCP + Int(costFrag6.Text) * skillFrag6.Value
        SpentCP = SpentCP + Int(costLooting.Text) * skillLooting.Value
        SpentCP = SpentCP + Int(costCreateAlcohol.Text) * skillCreateAlcohol.Value
        SpentCP = SpentCP + Int(costTeacher.Text) * skillTeacher.Value
        SpentCP = SpentCP + Int(costPossum.Text) * skillPossum.Value
        SpentCP = SpentCP + Int(costParagon.Text) * skillParagon.Value
        SpentCP = SpentCP + Int(costHeavyDrinker.Text) * skillHeavyDrinker.Value

		SpentCP = SpentCP + Int(costSpellVersa1.Text) * skillSpellVersa1.Value
		SpentCP = SpentCP + Int(costSpellVersa2.Text) * skillSpellVersa2.Value
		SpentCP = SpentCP + Int(costSpellVersa3.Text) * skillSpellVersa3.Value
		SpentCP = SpentCP + Int(costSpellVersa4.Text) * skillSpellVersa4.Value
		SpentCP = SpentCP + Int(costSpellVersa5.Text) * skillSpellVersa5.Value
		SpentCP = SpentCP + Int(costSpellVersa6.Text) * skillSpellVersa6.Value
		SpentCP = SpentCP + Int(costSpellVersa7.Text) * skillSpellVersa7.Value
		SpentCP = SpentCP + Int(costSpellVersa8.Text) * skillSpellVersa8.Value
        SpentCP = SpentCP + Int(costSpellVersa9.Text) * skillSpellVersa9.Value

        If Job > 1008 Then
            SpentCP = SpentCP + Int(costFavoured.Text)
        End If

    End Sub
	Public Sub SkillListBuild()
		boxSkillBreakdown.Text = ""
		If skillAlchemy.Value > 0 Then boxSkillBreakdown.AppendText(lblAlchemy.Text & " X " & skillAlchemy.Value & "   " & costAlchemy.Text * skillAlchemy.Value & vbNewLine)
		If skillBlacksmith.Value > 0 Then boxSkillBreakdown.AppendText(lblBlacksmith.Text & " X " & skillBlacksmith.Value & "   " & costBlacksmith.Text * skillBlacksmith.Value & vbNewLine)
        If skillCraft1.Value > 0 Then boxSkillBreakdown.AppendText(lblCraft1.Text & " X " & skillCraft1.Value & "   " & costCraft1.Text * skillCraft1.Value & vbNewLine)
        If skillCraft1.Value > 0 And boxCraft1.Text <> "" Then boxSkillBreakdown.AppendText(lblCraft1.Text & " " & boxCraft1.Text & vbNewLine)
        If skillCraft1.Value > 1 And boxCraft2.Text <> "" Then boxSkillBreakdown.AppendText(lblCraft1.Text & " " & boxCraft2.Text & vbNewLine)
        If skillCraft1.Value > 2 And boxCraft3.Text <> "" Then boxSkillBreakdown.AppendText(lblCraft1.Text & " " & boxCraft3.Text & vbNewLine)
        If skillCraft1.Value > 3 And boxCraft4.Text <> "" Then boxSkillBreakdown.AppendText(lblCraft1.Text & " " & boxCraft4.Text & vbNewLine)
        If skillCreateScroll.Value > 0 Then boxSkillBreakdown.AppendText(lblCreateScroll.Text & " X " & skillCreateScroll.Value & "   " & costCreateScroll.Text * skillCreateScroll.Value & vbNewLine)
		If skillTrapsmith.Value > 0 Then boxSkillBreakdown.AppendText(lblTrapsmith.Text & " X " & skillTrapsmith.Value & "   " & costTrapsmith.Text * skillTrapsmith.Value & vbNewLine)
		If skillAnatomy.Value > 0 Then boxSkillBreakdown.AppendText(lblAnatomy.Text & "   " & costAnatomy.Text * skillAnatomy.Value & vbNewLine)
		If skillMysticism.Value > 0 Then boxSkillBreakdown.AppendText(lblMysticism.Text & " X " & skillMysticism.Value & "   " & costMysticism.Text * skillMysticism.Value & vbNewLine)
		If skillDemonAngelArts.Value > 0 Then boxSkillBreakdown.AppendText(lblDemonAngelArts.Text & "   " & costDemonAngelArts.Text * skillDemonAngelArts.Value & vbNewLine)

		If skillEleAttunement.Value > 0 Then
			Select Case skillEleAttunement.Value
				Case 1
					boxSkillBreakdown.AppendText(lblEleAttunement.Text & " " & ddlEleAttunement2.SelectedItem & "   " & costEleAttunement.Text & vbNewLine)
				Case 2
					boxSkillBreakdown.AppendText(lblEleAttunement.Text & " " & ddlEleAttunement2.SelectedItem & "   " & costEleAttunement.Text & vbNewLine)
					boxSkillBreakdown.AppendText(lblEleAttunement.Text & " " & ddlEleAttunement3.SelectedItem & "   " & costEleAttunement.Text & vbNewLine)
				Case 3
					boxSkillBreakdown.AppendText(lblEleAttunement.Text & " " & ddlEleAttunement2.SelectedItem & "   " & costEleAttunement.Text & vbNewLine)
					boxSkillBreakdown.AppendText(lblEleAttunement.Text & " " & ddlEleAttunement3.SelectedItem & "   " & costEleAttunement.Text & vbNewLine)
					boxSkillBreakdown.AppendText(lblEleAttunement.Text & " " & ddlEleAttunement4.SelectedItem & "   " & costEleAttunement.Text & vbNewLine)
			End Select
		End If

		If skillFirstAid.Value > 0 Then boxSkillBreakdown.AppendText(lblFirstAid.Text & "   " & costFirstAid.Text * skillFirstAid.Value & vbNewLine)
		If skillNecroArts.Value > 0 Then boxSkillBreakdown.AppendText(lblNecroArts.Text & "   " & costNecroArts.Text * skillNecroArts.Value & vbNewLine)
		If skillPhysician.Value > 0 Then boxSkillBreakdown.AppendText(lblPhysician.Text & "   " & costPhysician.Text * skillPhysician.Value & vbNewLine)
		If skillReadAndWrite.Value > 0 Then boxSkillBreakdown.AppendText(lblReadAndWrite.Text & "   " & costReadAndWrite.Text * skillReadAndWrite.Value & vbNewLine)
		If skillReadMagic.Value > 0 Then boxSkillBreakdown.AppendText(lblReadMagic.Text & "   " & costReadMagic.Text * skillReadMagic.Value & vbNewLine)
		If skillReadMagicAvd.Value > 0 Then boxSkillBreakdown.AppendText(lblReadMagicAvd.Text & "   " & costReadMagicAvd.Text * skillReadMagicAvd.Value & vbNewLine)
		If skillReadMagicRitual.Value > 0 Then boxSkillBreakdown.AppendText(lblReadMagicRitual.Text & "   " & costReadMagicRitual.Text * skillReadMagicRitual.Value & vbNewLine)
		If skillSpell1.Value > 0 Then boxSkillBreakdown.AppendText("1st Circle slots:" & skillSpell1.Value & "   " & costSpell1.Text * skillSpell1.Value & vbNewLine)
		If skillSpell2.Value > 0 Then boxSkillBreakdown.AppendText("2nd Circle slots:" & skillSpell2.Value & "   " & costSpell2.Text * skillSpell2.Value & vbNewLine)
		If skillSpell3.Value > 0 Then boxSkillBreakdown.AppendText("3rd Circle slots:" & skillSpell3.Value & "   " & costSpell3.Text * skillSpell3.Value & vbNewLine)
		If skillSpell4.Value > 0 Then boxSkillBreakdown.AppendText("4th Circle slots:" & skillSpell4.Value & "   " & costSpell4.Text * skillSpell4.Value & vbNewLine)
		If skillSpell5.Value > 0 Then boxSkillBreakdown.AppendText("5th Circle slots:" & skillSpell5.Value & "   " & costSpell5.Text * skillSpell5.Value & vbNewLine)
		If skillSpell6.Value > 0 Then boxSkillBreakdown.AppendText("6th Circle slots:" & skillSpell6.Value & "   " & costSpell6.Text * skillSpell6.Value & vbNewLine)
		If skillSpell7.Value > 0 Then boxSkillBreakdown.AppendText("7th Circle slots:" & skillSpell7.Value & "   " & costSpell7.Text * skillSpell7.Value & vbNewLine)
		If skillSpell8.Value > 0 Then boxSkillBreakdown.AppendText("8th Circle slots:" & skillSpell8.Value & "   " & costSpell8.Text * skillSpell8.Value & vbNewLine)
		If skillSpell9.Value > 0 Then boxSkillBreakdown.AppendText("9th Circle slots:" & skillSpell9.Value & "   " & costSpell9.Text * skillSpell9.Value & vbNewLine)

		If skillSpellRitual.Value > 0 Then
			For i = 1 To skillSpellRitual.Value
				boxSkillBreakdown.AppendText("Ritual Magic Level: " & i & "   " & CostRitualCircle.Text * i & vbNewLine)
			Next i
		End If
		If skillSphere1.Value > 0 Then
			boxSkillBreakdown.AppendText("Sphere 1: " & ddlSphere1.SelectedItem & " ")
			If ddlSphere1.SelectedItem = "Elemental" Then boxSkillBreakdown.AppendText(ddlEleAttunement1.SelectedItem & "   " & costSphere1.Text * skillSphere1.Value & vbNewLine) Else boxSkillBreakdown.AppendText("   " & costSphere1.Text * skillSphere1.Value & vbNewLine)
		End If

		If skillSphere2.Value > 0 Then
			boxSkillBreakdown.AppendText("Sphere 2: " & ddlSphere2.SelectedItem & "   ")
			If ddlSphere2.SelectedItem = "Elemental" Then boxSkillBreakdown.AppendText(ddlEleAttunement1.SelectedItem & "   " & costSphere2.Text * skillSphere2.Value & vbNewLine) Else boxSkillBreakdown.AppendText("   " & costSphere2.Text * skillSphere2.Value & vbNewLine)
		End If


        If skillSphere3.Value > 0 Then
            boxSkillBreakdown.AppendText("Sphere 3: " & ddlSphere3.SelectedItem & "   ")
            If ddlSphere3.SelectedItem = "Elemental" Then boxSkillBreakdown.AppendText(ddlEleAttunement1.SelectedItem & "   " & costSphere3.Text * skillSphere3.Value & vbNewLine) Else boxSkillBreakdown.AppendText("   " & costSphere3.Text * skillSphere3.Value & vbNewLine)
        End If

        If skillAdvRitual.Value > 0 Then boxSkillBreakdown.AppendText(lblAdvRitual.Text & "   " & costAdvRitual.Text * skillAdvRitual.Value & vbNewLine)

        If skillAmbidexterity.Value > 0 Then boxSkillBreakdown.AppendText(lblAmbidexterity.Text & "   " & costAmbidexterity.Text * skillAmbidexterity.Value & vbNewLine)
		If skillFlorentine.Value > 0 Then boxSkillBreakdown.AppendText(lblFlorentine.Text & "   " & costFlorentine.Text * skillFlorentine.Value & vbNewLine)
		If skillFlurryOfBlows.Value > 0 Then boxSkillBreakdown.AppendText(lblFlurryofBlows.Text & " X " & skillFlurryOfBlows.Value & "   " & costFlurryOfBlows.Text * skillFlurryOfBlows.Value & vbNewLine)
		If skillHeavyArmour.Value > 0 Then boxSkillBreakdown.AppendText(lblHeavyArmour.Text & "   " & costHeavyArmour.Text * skillHeavyArmour.Value & vbNewLine)
		If skillSelfMut.Value > 0 Then boxSkillBreakdown.AppendText(lblSelfMut.Text & "   " & costSelfMut.Text * skillSelfMut.Value & vbNewLine)
		If skillShield.Value > 0 Then boxSkillBreakdown.AppendText(lblShield.Text & "   " & costShield.Text * skillShield.Value & vbNewLine)
		If skillSlayParry.Value > 0 AndAlso ddlSlayParryWeapon.SelectedIndex <> -1 Then boxSkillBreakdown.AppendText(lblSlayParry.Text & " " & ddlSlayParryWeapon.SelectedItem & " X " & skillSlayParry.Value & "   " & costSlayParry.Text * skillSlayParry.Value & vbNewLine)
		If skillSlayParryMaster.Value > 0 AndAlso ddlSlayParryMasterWeapon.SelectedIndex <> -1 Then boxSkillBreakdown.AppendText(lblSlayParryMaster.Text & " " & ddlSlayParryMasterWeapon.SelectedItem & " X " & skillSlayParryMaster.Value & "   " & costSlayParryMaster.Text * skillSlayParryMaster.Value & vbNewLine)
		If skillSpecGroup.Value > 0 AndAlso ddlSpecGroup.SelectedIndex <> -1 Then boxSkillBreakdown.AppendText(lblSpecGroup.Text & " " & ddlSpecGroup.SelectedItem & "   " & costSpecGroup.Text * skillSpecGroup.Value & vbNewLine)
		If skillSpecSpecific.Value > 0 AndAlso ddlSpecSpecific.SelectedIndex <> -1 Then boxSkillBreakdown.AppendText(lblSpecSpecific.Text & " " & ddlSpecSpecific.SelectedItem & "   " & costSpecSpecific.Text * skillSpecSpecific.Value & vbNewLine)
		If skillSimpleProf.Value > 0 Then boxSkillBreakdown.AppendText(lblSimpleProf.Text & "   " & costSimpleProf.Text * skillSimpleProf.Value & vbNewLine)
		If skillMedProf.Value > 0 Then boxSkillBreakdown.AppendText(lblMedProf.Text & "   " & costMedProf.Text * skillMedProf.Value & vbNewLine)
		If skillLargeProf.Value > 0 Then boxSkillBreakdown.AppendText(lblLargeProf.Text & "   " & costLargeProf.Text * skillLargeProf.Value & vbNewLine)
		If skillExoticProf.Value > 0 AndAlso ddlExoticWeapon.SelectedIndex <> -1 Then boxSkillBreakdown.AppendText(lblExoticProf.Text & " " & ddlExoticWeapon.SelectedItem & "   " & costExoticProf.Text * skillExoticProf.Value & vbNewLine)
		If skillWeaponRefocus.Value > 0 Then boxSkillBreakdown.AppendText(lblWeaponRefocus.Text & " X " & skillWeaponRefocus.Value & "   " & costWeaponRefocus.Text * skillWeaponRefocus.Value & vbNewLine)
		If skillCritSpecific.Value > 0 Then boxSkillBreakdown.AppendText(lblCritSpecific.Text & " X " & skillCritSpecific.Value & "   " & costCritSpecific.Text * skillCritSpecific.Value & vbNewLine)
		If skillCritGroup.Value > 0 Then boxSkillBreakdown.AppendText(lblCritGroup.Text & " X " & skillCritGroup.Value & "   " & costCritGroup.Text * skillCritGroup.Value & vbNewLine)
		If skillDodge.Value > 0 Then boxSkillBreakdown.AppendText(lblDodge.Text & " X " & skillDodge.Value & "   " & costDodge.Text * skillDodge.Value & vbNewLine)
		If skillExecute.Value > 0 Then boxSkillBreakdown.AppendText(lblExecute.Text & " X " & skillExecute.Value & "   " & costExecute.Text * skillExecute.Value & vbNewLine)
		If skillExecuteMaster.Value > 0 Then boxSkillBreakdown.AppendText(lblExecuteMaster.Text & " X " & skillExecuteMaster.Value & "   " & costExecuteMaster.Text * skillExecuteMaster.Value & vbNewLine)
		If skillGarrote.Value > 0 Then boxSkillBreakdown.AppendText(lblGarrote.Text & "   " & costGarrote.Text * skillGarrote.Value & vbNewLine)
        If skillSap.Value > 0 Then boxSkillBreakdown.AppendText(lblSap.Text & " X " & skillSap.Value & "   " & costSap.Text * skillSap.Value & vbNewLine)
        If skillVitalBlow.Value > 0 Then boxSkillBreakdown.AppendText(lblVitalBlow.Text & " X " & skillVitalBlow.Value & "   " & costVitalBlow.Text * skillVitalBlow.Value & vbNewLine)
		If skillJob1.Value > 0 Then boxSkillBreakdown.AppendText(lblJob1.Text & " X " & skillJob1.Value & "   " & costJob1.Text * skillJob1.Value & vbNewLine)
		If skillJob2.Value > 0 Then boxSkillBreakdown.AppendText(lblJob2.Text & " X " & skillJob2.Value & "   " & costJob2.Text * skillJob2.Value & vbNewLine)
		If skillJob3.Value > 0 Then boxSkillBreakdown.AppendText(lblJob3.Text & " X " & skillJob3.Value & "   " & costJob3.Text * skillJob3.Value & vbNewLine)
		If skillJob4.Value > 0 Then boxSkillBreakdown.AppendText(lblJob4.Text & " X " & skillJob4.Value & "   " & costJob4.Text * skillJob4.Value & vbNewLine)

		If skillRacial2.Value > 0 Then boxSkillBreakdown.AppendText(lblRacial2.Text & " X " & skillRacial2.Value & "   " & costRacial2.Text * skillRacial2.Value & vbNewLine)
		If skillBPB.Value > 0 Then boxSkillBreakdown.AppendText(lblBPB.Text & " X " & skillBPB.Value & "   " & costBPB.Text * skillBPB.Value & vbNewLine)
		If skillStr.Value > 0 Then boxSkillBreakdown.AppendText(lblStr.Text & " X " & skillStr.Value & "   " & costStr.Text * skillStr.Value & vbNewLine)
		If Race <> 802 AndAlso Race <> 0 Then
            boxSkillBreakdown.AppendText("Racial: " & lblRacialAuto.Text)
        End If


		If Race = 809 Then
			boxSkillBreakdown.AppendText(" - " & listRacial.Text)
		ElseIf Race = 810 Then
			boxSkillBreakdown.AppendText(" - " & listRacial.Text & " Dmg +" & (Int((Level - 1) / 3) + 1))
		ElseIf Race = 814 Then
			boxSkillBreakdown.AppendText((Int(Level / 3) + 1))
		ElseIf Race = 822 Then
			boxSkillBreakdown.AppendText(" X " & (Int(Level / 4) + 1))
		ElseIf Race = 829 Then
            boxSkillBreakdown.AppendText(" Level " & skillRacialAuto.Value)
        ElseIf Race = 831 Then
			boxSkillBreakdown.AppendText(" " & (Int(Level * 3)))
		End If
		If Race <> 802 AndAlso Race <> 0 Then
			boxSkillBreakdown.AppendText(vbNewLine)
		End If

		If skillFrag1.Value > 0 Then boxSkillBreakdown.AppendText(lblFrag1.Text & " X " & skillFrag1.Value & "   " & costFrag1.Text * skillFrag1.Value & vbNewLine)

		If skillFrag2.Value > 0 Then boxSkillBreakdown.AppendText(lblFrag2.Text & " X " & skillFrag2.Value & "   " & costFrag2.Text * skillFrag2.Value & vbNewLine)

		If skillFrag3.Value > 0 Then boxSkillBreakdown.AppendText(lblFrag3.Text & " X " & skillFrag3.Value & "   " & costFrag3.Text * skillFrag3.Value & vbNewLine)

		If skillFrag4.Value > 0 Then boxSkillBreakdown.AppendText(lblFrag4.Text & " X " & skillFrag4.Value & "   " & costFrag4.Text * skillFrag4.Value & vbNewLine)

		If skillFrag5.Value > 0 Then boxSkillBreakdown.AppendText(lblFrag5.Text & " X " & skillFrag5.Value & "   " & costFrag5.Text * skillFrag5.Value & vbNewLine)

		If skillFrag6.Value > 0 Then boxSkillBreakdown.AppendText(lblFrag6.Text & " X " & skillFrag6.Value & "   " & costFrag6.Text * skillFrag6.Value & vbNewLine)

		If skillHeavyDrinker.Value > 0 Then boxSkillBreakdown.AppendText(lblHeavyDrinker.Text & " X " & skillHeavyDrinker.Value & "   " & costHeavyDrinker.Text * skillHeavyDrinker.Value & vbNewLine)

        If skillLooting.Value > 0 Then boxSkillBreakdown.AppendText(lblLooting.Text & " X " & skillLooting.Value & "   " & costLooting.Text * skillLooting.Value & vbNewLine)
        If skillCreateAlcohol.Value > 0 Then boxSkillBreakdown.AppendText(lblLooting.Text & " X " & skillCreateAlcohol.Value & "   " & costCreateAlcohol.Text * skillCreateAlcohol.Value & vbNewLine)
        If skillPossum.Value > 0 Then boxSkillBreakdown.AppendText(lblPossum.Text & " X " & skillPossum.Value & "   " & costPossum.Text * skillPossum.Value & vbNewLine)
        If skillParagon.Value > 0 Then boxSkillBreakdown.AppendText(lblParagon.Text & " X " & skillParagon.Value & "   " & costParagon.Text * skillParagon.Value & vbNewLine)
        If skillTeacher.Value > 0 Then boxSkillBreakdown.AppendText(lblFuckYou.Text & " X " & skillTeacher.Value & "   " & costTeacher.Text * skillTeacher.Value & vbNewLine)

        If Job > 1008 Then boxSkillBreakdown.AppendText("Favoured   50" & vbNewLine)

        If skillSpellVersa1.Value > 0 Then boxSkillBreakdown.AppendText("Spell Versatility - Slot 1   " & costSpellVersa1.Text + 10 & vbNewLine)
        If skillSpellVersa2.Value > 0 Then boxSkillBreakdown.AppendText("Spell Versatility - Slot 2   " & costSpellVersa2.Text + 10 & vbNewLine)
        If skillSpellVersa3.Value > 0 Then boxSkillBreakdown.AppendText("Spell Versatility - Slot 3   " & costSpellVersa3.Text + 10 & vbNewLine)
        If skillSpellVersa4.Value > 0 Then boxSkillBreakdown.AppendText("Spell Versatility - Slot 4   " & costSpellVersa4.Text + 10 & vbNewLine)
        If skillSpellVersa5.Value > 0 Then boxSkillBreakdown.AppendText("Spell Versatility - Slot 5   " & costSpellVersa5.Text + 10 & vbNewLine)
        If skillSpellVersa6.Value > 0 Then boxSkillBreakdown.AppendText("Spell Versatility - Slot 6   " & costSpellVersa6.Text + 10 & vbNewLine)
        If skillSpellVersa7.Value > 0 Then boxSkillBreakdown.AppendText("Spell Versatility - Slot 7   " & costSpellVersa7.Text + 10 & vbNewLine)
        If skillSpellVersa8.Value > 0 Then boxSkillBreakdown.AppendText("Spell Versatility - Slot 8   " & costSpellVersa8.Text + 10 & vbNewLine)
        If skillSpellVersa9.Value > 0 Then boxSkillBreakdown.AppendText("Spell Versatility - Slot 9   " & costSpellVersa9.Text + 10 & vbNewLine)

    End Sub
    Public Sub Production()

        If chkVocation.Checked = True Then
            Job = ddlCharJob.SelectedIndex + 1000
        End If

        Select Case Job
            Case 1000
                costAlchemy.Text = 80
                costBlacksmith.Text = 65
                costCraft1.Text = 40
                costCreateScroll.Text = 75
                costTrapsmith.Text = 75
                costChemistry.Text = 90
                costArtifice.Text = 75
            Case 1001
                costAlchemy.Text = 50
                costBlacksmith.Text = 65
                costCraft1.Text = 40
                costCreateScroll.Text = 75
                costTrapsmith.Text = 65
                costChemistry.Text = 60
                costArtifice.Text = 75
            Case 1002
                costAlchemy.Text = 70
                costBlacksmith.Text = 70
                costChemistry.Text = 80
                costArtifice.Text = 80
                costCraft1.Text = 40
                costCreateScroll.Text = 40
                costTrapsmith.Text = 75
            Case 1003
                costAlchemy.Text = 40
                costBlacksmith.Text = 80
                costChemistry.Text = 50
                costArtifice.Text = 90
                costCraft1.Text = 40
                costCreateScroll.Text = 50
                costTrapsmith.Text = 45
            Case 1004
                costAlchemy.Text = 40
                costBlacksmith.Text = 90
                costChemistry.Text = 50
                costArtifice.Text = 100
                costCraft1.Text = 40
                costCreateScroll.Text = 75
                costTrapsmith.Text = 55
            Case 1005
                costAlchemy.Text = 50
                costBlacksmith.Text = 80
                costChemistry.Text = 60
                costArtifice.Text = 90
                costCraft1.Text = 40
                costCreateScroll.Text = 45
                costTrapsmith.Text = 65
            Case 1006
                costAlchemy.Text = 60
                costBlacksmith.Text = 110
                costChemistry.Text = 70
                costArtifice.Text = 120
                costCraft1.Text = 40
                costCreateScroll.Text = 35
                costTrapsmith.Text = 85
            Case 1007
                costAlchemy.Text = 40
                costBlacksmith.Text = 100
                costChemistry.Text = 50
                costArtifice.Text = 110
                costCraft1.Text = 40
                costCreateScroll.Text = 45
                costTrapsmith.Text = 75
            Case 1008
                costAlchemy.Text = 50
                costBlacksmith.Text = 85
                costChemistry.Text = 60
                costArtifice.Text = 110
                costCraft1.Text = 35
                costCreateScroll.Text = 35
                costTrapsmith.Text = 75
            Case 1009 To 1010
                costAlchemy.Text = 90
                costBlacksmith.Text = 75
                costChemistry.Text = 100
                costArtifice.Text = 85
                costCraft1.Text = 50
                costCreateScroll.Text = 50
                costTrapsmith.Text = 85
            Case 1011 To 1113
                costAlchemy.Text = 70
                costBlacksmith.Text = 110
                costChemistry.Text = 80
                costArtifice.Text = 120
                costCraft1.Text = 40
                costCreateScroll.Text = 40
                costTrapsmith.Text = 85
        End Select
    End Sub
    Public Sub Circles()

        If chkVocation.Checked = True Then
            Job = ddlCharJob.SelectedIndex + 1000
        End If

        Select Case Job
            Case 1000
                costSpell1.Text = 30
                costSpell2.Text = 40
                costSpell3.Text = 80
                costSpell4.Text = 100
                costSpell5.Text = 100
                costSpell6.Text = 120
                costSpell7.Text = 120
                costSpell8.Text = 150
                costSpell9.Text = 150
                CostRitualCircle.Text = 40
            Case 1001
                costSpell1.Text = 30
                costSpell2.Text = 30
                costSpell3.Text = 60
                costSpell4.Text = 60
                costSpell5.Text = 90
                costSpell6.Text = 90
                costSpell7.Text = 120
                costSpell8.Text = 120
                costSpell9.Text = 150
                CostRitualCircle.Text = 30
            Case 1002
                costSpell1.Text = 10
                costSpell2.Text = 10
                costSpell3.Text = 20
                costSpell4.Text = 30
                costSpell5.Text = 40
                costSpell6.Text = 50
                costSpell7.Text = 60
                costSpell8.Text = 70
                costSpell9.Text = 80
                CostRitualCircle.Text = 30
            Case 1003
                costSpell1.Text = 20
                costSpell2.Text = 20
                costSpell3.Text = 40
                costSpell4.Text = 40
                costSpell5.Text = 60
                costSpell6.Text = 60
                costSpell7.Text = 80
                costSpell8.Text = 80
                costSpell9.Text = 100
                CostRitualCircle.Text = 20
            Case 1004
                costSpell1.Text = 40
                costSpell2.Text = 60
                costSpell3.Text = 80
                costSpell4.Text = 100
                costSpell5.Text = 100
                costSpell6.Text = 120
                costSpell7.Text = 120
                costSpell8.Text = 150
                costSpell9.Text = 150
                CostRitualCircle.Text = 40
            Case 1005
                costSpell1.Text = 10
                costSpell2.Text = 10
                costSpell3.Text = 20
                costSpell4.Text = 30
                costSpell5.Text = 30
                costSpell6.Text = 40
                costSpell7.Text = 50
                costSpell8.Text = 50
                costSpell9.Text = 60
                CostRitualCircle.Text = 20
            Case 1006
                costSpell1.Text = 10
                costSpell2.Text = 10
                costSpell3.Text = 20
                costSpell4.Text = 20
                costSpell5.Text = 30
                costSpell6.Text = 30
                costSpell7.Text = 40
                costSpell8.Text = 40
                costSpell9.Text = 50
                CostRitualCircle.Text = 10
            Case 1007
                costSpell1.Text = 10
                costSpell2.Text = 10
                costSpell3.Text = 20
                costSpell4.Text = 20
                costSpell5.Text = 30
                costSpell6.Text = 30
                costSpell7.Text = 40
                costSpell8.Text = 40
                costSpell9.Text = 50
                CostRitualCircle.Text = 10
            Case 1008
                costSpell1.Text = 10
                costSpell2.Text = 10
                costSpell3.Text = 20
                costSpell4.Text = 30
                costSpell5.Text = 30
                costSpell6.Text = 40
                costSpell7.Text = 60
                costSpell8.Text = 70
                costSpell9.Text = 80
                CostRitualCircle.Text = 30
            Case 1009 To 1010
                costSpell1.Text = 10
                costSpell2.Text = 20
                costSpell3.Text = 40
                costSpell4.Text = 40
                costSpell5.Text = 50
                costSpell6.Text = 60
                costSpell7.Text = 70
                costSpell8.Text = 80
                costSpell9.Text = 100
                CostRitualCircle.Text = 30
            Case 1011 To 1013
                costSpell1.Text = 10
                costSpell2.Text = 10
                costSpell3.Text = 20
                costSpell4.Text = 20
                costSpell5.Text = 30
                costSpell6.Text = 30
                costSpell7.Text = 40
                costSpell8.Text = 40
                costSpell9.Text = 50
                CostRitualCircle.Text = 10
        End Select

        costSpellVersa1.Text = 10 + Integer.Parse(costSpell1.Text)
        costSpellVersa2.Text = 10 + Integer.Parse(costSpell2.Text)
        costSpellVersa3.Text = 10 + Integer.Parse(costSpell3.Text)
        costSpellVersa4.Text = 10 + Integer.Parse(costSpell4.Text)
        costSpellVersa5.Text = 10 + Integer.Parse(costSpell5.Text)
        costSpellVersa6.Text = 10 + Integer.Parse(costSpell6.Text)
        costSpellVersa7.Text = 10 + Integer.Parse(costSpell7.Text)
        costSpellVersa8.Text = 10 + Integer.Parse(costSpell8.Text)
        costSpellVersa9.Text = 10 + Integer.Parse(costSpell9.Text)

        If skillSpellRitual.Value < 10 Then
            costSpellRitual.Text = CostRitualCircle.Text * (skillSpellRitual.Value + 1)
        Else
            costSpellRitual.Text = "-"
        End If

    End Sub
    Public Sub ScholarSkills()

        If chkVocation.Checked = True Then
            Job = ddlCharJob.SelectedIndex + 1000
        End If

        Select Case Job
            Case 1000
                costAnatomy.Text = 40
                costDemonAngelArts.Text = 75
                costEleAttunement.Text = 25
                costFirstAid.Text = 60
                costNecroArts.Text = 75
                costPhysician.Text = 45
                costReadAndWrite.Text = 70
                costReadMagic.Text = 45
                costReadMagicAvd.Text = 50
                costReadMagicRitual.Text = 90
                costSphere1.Text = 100
                costSphere2.Text = 200
                costSphere3.Text = 300
                costAdvRitual.Text = 300
            Case 1001
                costAnatomy.Text = 40
                costDemonAngelArts.Text = 75
                costEleAttunement.Text = 25
                costFirstAid.Text = 60
                costNecroArts.Text = 75
                costPhysician.Text = 45
                costReadAndWrite.Text = 60
                costReadMagic.Text = 35
                costReadMagicAvd.Text = 45
                costReadMagicRitual.Text = 80
                costSphere1.Text = 100
                costSphere2.Text = 200
                costSphere3.Text = 300
                costAdvRitual.Text = 300
            Case 1002
                costAnatomy.Text = 40
                costDemonAngelArts.Text = 60
                costEleAttunement.Text = 25
                costFirstAid.Text = 60
                costNecroArts.Text = 60
                costPhysician.Text = 45
                costReadAndWrite.Text = 45
                costReadMagic.Text = 20
                costReadMagicAvd.Text = 30
                costReadMagicRitual.Text = 50
                costSphere1.Text = 75
                costSphere2.Text = 175
                costSphere3.Text = 275
                costAdvRitual.Text = 275
            Case 1003
                costAnatomy.Text = 40
                costDemonAngelArts.Text = 75
                costEleAttunement.Text = 25
                costFirstAid.Text = 60
                costNecroArts.Text = 75
                costPhysician.Text = 45
                costReadAndWrite.Text = 55
                costReadMagic.Text = 25
                costReadMagicAvd.Text = 35
                costReadMagicRitual.Text = 60
                costSphere1.Text = 75
                costSphere2.Text = 175
                costSphere3.Text = 275
                costAdvRitual.Text = 275
            Case 1004
                costAnatomy.Text = 40
                costDemonAngelArts.Text = 75
                costEleAttunement.Text = 25
                costFirstAid.Text = 60
                costNecroArts.Text = 75
                costPhysician.Text = 45
                costReadAndWrite.Text = 70
                costReadMagic.Text = 40
                costReadMagicAvd.Text = 50
                costReadMagicRitual.Text = 90
                costSphere1.Text = 100
                costSphere2.Text = 200
                costSphere3.Text = 300
                costAdvRitual.Text = 300
            Case 1005
                costAnatomy.Text = 40
                costDemonAngelArts.Text = 60
                costEleAttunement.Text = 25
                costFirstAid.Text = 60
                costNecroArts.Text = 60
                costPhysician.Text = 45
                costReadAndWrite.Text = 45
                costReadMagic.Text = 25
                costReadMagicAvd.Text = 35
                costReadMagicRitual.Text = 60
                costSphere1.Text = 75
                costSphere2.Text = 175
                costSphere3.Text = 275
                costAdvRitual.Text = 275
            Case 1006
                costAnatomy.Text = 40
                costDemonAngelArts.Text = 55
                costEleAttunement.Text = 25
                costFirstAid.Text = 60
                costNecroArts.Text = 55
                costPhysician.Text = 45
                costReadAndWrite.Text = 40
                costReadMagic.Text = 15
                costReadMagicAvd.Text = 25
                costReadMagicRitual.Text = 40
                costSphere1.Text = 25
                costSphere2.Text = 150
                costSphere3.Text = 200
                costAdvRitual.Text = 200
            Case 1007
                costAnatomy.Text = 40
                costDemonAngelArts.Text = 60
                costEleAttunement.Text = 25
                costFirstAid.Text = 60
                costNecroArts.Text = 60
                costPhysician.Text = 45
                costReadAndWrite.Text = 50
                costReadMagic.Text = 15
                costReadMagicAvd.Text = 25
                costReadMagicRitual.Text = 40
                costSphere1.Text = 50
                costSphere2.Text = 175
                costSphere3.Text = 225
                costAdvRitual.Text = 225
            Case 1008
                costAnatomy.Text = 35
                costDemonAngelArts.Text = 50
                costEleAttunement.Text = 25
                costFirstAid.Text = 55
                costNecroArts.Text = 55
                costPhysician.Text = 40
                costReadAndWrite.Text = 40
                costReadMagic.Text = 25
                costReadMagicAvd.Text = 35
                costReadMagicRitual.Text = 50
                costSphere1.Text = 50
                costSphere2.Text = 175
                costSphere3.Text = 225
                costAdvRitual.Text = 225
            Case 1009 To 1010
                costAnatomy.Text = 40
                costDemonAngelArts.Text = 40
                costEleAttunement.Text = 25
                costFirstAid.Text = 60
                costNecroArts.Text = 40
                costPhysician.Text = 45
                costReadAndWrite.Text = 50
                costReadMagic.Text = 30
                costReadMagicAvd.Text = 50
                costReadMagicRitual.Text = 50
                costSphere1.Text = 50
                costSphere2.Text = 200
                costSphere3.Text = 300
                costAdvRitual.Text = 275
            Case 1011 To 1013
                costAnatomy.Text = 40
                costDemonAngelArts.Text = 45
                costEleAttunement.Text = 25
                costFirstAid.Text = 60
                costNecroArts.Text = 45
                costPhysician.Text = 45
                costReadAndWrite.Text = 40
                costReadMagic.Text = 15
                costReadMagicAvd.Text = 25
                costReadMagicRitual.Text = 40
                costSphere1.Text = 50
                costSphere2.Text = 175
                costSphere3.Text = 225
                costAdvRitual.Text = 200
        End Select

    End Sub

    Public Sub WarriorSkills()

        If chkVocation.Checked = True Then
            Job = ddlCharJob.SelectedIndex + 1000
        End If

        Select Case Job
            Case 1000
                costAmbidexterity.Text = 20
                costFlorentine.Text = 40
                costFlurryOfBlows.Text = 40
                costHeavyArmour.Text = 15
                costShield.Text = 50
                costSlayParry.Text = 100
                costSlayParryMaster.Text = 120
                costSpecGroup.Text = 120
                costSpecSpecific.Text = 100
                costSimpleProf.Text = 0
                costMedProf.Text = 40
                costLargeProf.Text = 70
                costExoticProf.Text = 100
                costWeaponRefocus.Text = 40
            Case 1001
                costAmbidexterity.Text = 30
                costFlorentine.Text = 40
                costFlurryOfBlows.Text = 50
                costHeavyArmour.Text = 20
                costShield.Text = 75
                costSlayParry.Text = 120
                costSlayParryMaster.Text = 140
                costSpecGroup.Text = 140
                costSpecSpecific.Text = 120
                costSimpleProf.Text = 0
                costMedProf.Text = 40
                costLargeProf.Text = 70
                costExoticProf.Text = 100
                costWeaponRefocus.Text = 40
            Case 1002
                costAmbidexterity.Text = 35
                costFlorentine.Text = 45
                costFlurryOfBlows.Text = 55
                costHeavyArmour.Text = 20
                costShield.Text = 60
                costSlayParry.Text = 130
                costSlayParryMaster.Text = 150
                costSpecGroup.Text = 150
                costSpecSpecific.Text = 130
                costSimpleProf.Text = 0
                costMedProf.Text = 40
                costLargeProf.Text = 70
                costExoticProf.Text = 100
                costWeaponRefocus.Text = 40
            Case 1003
                costAmbidexterity.Text = 40
                costFlorentine.Text = 70
                costFlurryOfBlows.Text = 75
                costHeavyArmour.Text = 40
                costShield.Text = 110
                costSlayParry.Text = 170
                costSlayParryMaster.Text = 190
                costSpecGroup.Text = 170
                costSpecSpecific.Text = 150
                costSimpleProf.Text = 0
                costMedProf.Text = 50
                costLargeProf.Text = 100
                costExoticProf.Text = 130
                costWeaponRefocus.Text = 40
            Case 1004
                costAmbidexterity.Text = 30
                costFlorentine.Text = 65
                costFlurryOfBlows.Text = 65
                costHeavyArmour.Text = 45
                costShield.Text = 120
                costSlayParry.Text = 150
                costSlayParryMaster.Text = 170
                costSpecGroup.Text = 150
                costSpecSpecific.Text = 130
                costSimpleProf.Text = 0
                costMedProf.Text = 50
                costLargeProf.Text = 100
                costExoticProf.Text = 130
                costWeaponRefocus.Text = 40
            Case 1005
                costAmbidexterity.Text = 45
                costFlorentine.Text = 70
                costFlurryOfBlows.Text = 75
                costHeavyArmour.Text = 45
                costShield.Text = 95
                costSlayParry.Text = 170
                costSlayParryMaster.Text = 190
                costSpecGroup.Text = 170
                costSpecSpecific.Text = 150
                costSimpleProf.Text = 0
                costMedProf.Text = 50
                costLargeProf.Text = 100
                costExoticProf.Text = 130
                costWeaponRefocus.Text = 40
            Case 1006
                costAmbidexterity.Text = 75
                costFlorentine.Text = 110
                costFlurryOfBlows.Text = 125
                costHeavyArmour.Text = 65
                costShield.Text = 140
                costSlayParry.Text = 250
                costSlayParryMaster.Text = 270
                costSpecGroup.Text = 250
                costSpecSpecific.Text = 230
                costSimpleProf.Text = 0
                costMedProf.Text = 80
                costLargeProf.Text = 130
                costExoticProf.Text = 150
                costWeaponRefocus.Text = 40
            Case 1007
                costAmbidexterity.Text = 75
                costFlorentine.Text = 110
                costFlurryOfBlows.Text = 100
                costHeavyArmour.Text = 60
                costShield.Text = 140
                costSlayParry.Text = 200
                costSlayParryMaster.Text = 220
                costSpecGroup.Text = 200
                costSpecSpecific.Text = 180
                costSimpleProf.Text = 0
                costMedProf.Text = 80
                costLargeProf.Text = 130
                costExoticProf.Text = 150
                costWeaponRefocus.Text = 40
            Case 1008
                costAmbidexterity.Text = 75
                costFlorentine.Text = 110
                costFlurryOfBlows.Text = 125
                costHeavyArmour.Text = 65
                costShield.Text = 140
                costSlayParry.Text = 250
                costSlayParryMaster.Text = 270
                costSpecGroup.Text = 250
                costSpecSpecific.Text = 230
                costSimpleProf.Text = 0
                costMedProf.Text = 80
                costLargeProf.Text = 130
                costExoticProf.Text = 150
                costWeaponRefocus.Text = 40
            Case 1009 To 1010
                costAmbidexterity.Text = 40
                costFlorentine.Text = 50
                costFlurryOfBlows.Text = 45
                costHeavyArmour.Text = 10
                costShield.Text = 50
                costSlayParry.Text = 120
                costSlayParryMaster.Text = 140
                costSpecGroup.Text = 160
                costSpecSpecific.Text = 100
                costSimpleProf.Text = 0
                costMedProf.Text = 40
                costLargeProf.Text = 70
                costExoticProf.Text = 110
                costWeaponRefocus.Text = 40
            Case 1011 To 1013
                costAmbidexterity.Text = 75
                costFlorentine.Text = 110
                costFlurryOfBlows.Text = 100
                costHeavyArmour.Text = 65
                costShield.Text = 100
                costSlayParry.Text = 200
                costSlayParryMaster.Text = 220
                costSpecGroup.Text = 200
                costSpecSpecific.Text = 180
                costSimpleProf.Text = 0
                costMedProf.Text = 80
                costLargeProf.Text = 130
                costExoticProf.Text = 150
                costWeaponRefocus.Text = 40
        End Select

    End Sub
    Public Sub RogueSkills()

        If chkVocation.Checked = True Then
            Job = ddlCharJob.SelectedIndex + 1000
        End If

        Select Case Job
            Case 1000
                costCritSpecific.Text = 150
                costCritGroup.Text = 170
                costDodge.Text = 170
                costExecute.Text = 170
                costExecuteMaster.Text = 190
                costGarrote.Text = 100
                costSap.Text = 55
                costVitalBlow.Text = 85
            Case 1001
                costCritSpecific.Text = 125
                costCritGroup.Text = 145
                costDodge.Text = 140
                costExecute.Text = 130
                costExecuteMaster.Text = 150
                costGarrote.Text = 85
                costSap.Text = 45
                costVitalBlow.Text = 65
            Case 1002
                costCritSpecific.Text = 130
                costCritGroup.Text = 150
                costDodge.Text = 150
                costExecute.Text = 150
                costExecuteMaster.Text = 170
                costGarrote.Text = 120
                costSap.Text = 50
                costVitalBlow.Text = 75
            Case 1003
                costCritSpecific.Text = 120
                costCritGroup.Text = 140
                costDodge.Text = 100
                costExecute.Text = 120
                costExecuteMaster.Text = 150
                costGarrote.Text = 85
                costSap.Text = 35
                costVitalBlow.Text = 50
            Case 1004
                costCritSpecific.Text = 100
                costCritGroup.Text = 120
                costDodge.Text = 120
                costExecute.Text = 100
                costExecuteMaster.Text = 120
                costGarrote.Text = 60
                costSap.Text = 35
                costVitalBlow.Text = 55
            Case 1005
                costCritSpecific.Text = 130
                costCritGroup.Text = 150
                costDodge.Text = 130
                costExecute.Text = 130
                costExecuteMaster.Text = 150
                costGarrote.Text = 65
                costSap.Text = 35
                costVitalBlow.Text = 65
            Case 1006
                costCritSpecific.Text = 230
                costCritGroup.Text = 250
                costDodge.Text = 250
                costExecute.Text = 250
                costExecuteMaster.Text = 270
                costGarrote.Text = 150
                costSap.Text = 60
                costVitalBlow.Text = 120
            Case 1007
                costCritSpecific.Text = 180
                costCritGroup.Text = 200
                costDodge.Text = 200
                costExecute.Text = 200
                costExecuteMaster.Text = 220
                costGarrote.Text = 150
                costSap.Text = 60
                costVitalBlow.Text = 100
            Case 1008
                costCritSpecific.Text = 130
                costCritGroup.Text = 150
                costDodge.Text = 80
                costExecute.Text = 150
                costExecuteMaster.Text = 170
                costGarrote.Text = 95
                costSap.Text = 40
                costVitalBlow.Text = 75
            Case 1009 To 1010
                costCritSpecific.Text = 140
                costCritGroup.Text = 180
                costDodge.Text = 170
                costExecute.Text = 170
                costExecuteMaster.Text = 190
                costGarrote.Text = 140
                costSap.Text = 55
                costVitalBlow.Text = 85
            Case 1011 To 1013
                costCritSpecific.Text = 180
                costCritGroup.Text = 200
                costDodge.Text = 200
                costExecute.Text = 200
                costExecuteMaster.Text = 220
                costGarrote.Text = 150
                costSap.Text = 60
                costVitalBlow.Text = 100
        End Select
    End Sub

    Public Sub FragSkills()

        If Job >= 1100 Then
            Job = ddlCharJob.SelectedIndex + 1000
        End If

        Select Case Job

            Case 1000 To 1002

                lblFrag1.Visible = True
                lblFrag2.Visible = True
                lblFrag3.Visible = True
                lblFrag4.Visible = True
                lblFrag5.Visible = True
                lblFrag6.Visible = True
                lblSpellVersa.Visible = False
                lblSpellVersa1.Visible = False
                lblSpellVersa2.Visible = False
                lblSpellVersa3.Visible = False
                lblSpellVersa4.Visible = False
                lblSpellVersa5.Visible = False
                lblSpellVersa6.Visible = False
                lblSpellVersa7.Visible = False
                lblSpellVersa8.Visible = False
                lblSpellVersa9.Visible = False

                costFrag1.Visible = True
                costFrag2.Visible = True
                costFrag3.Visible = True
                costFrag4.Visible = True
                costFrag5.Visible = True
                costFrag6.Visible = True
                costSpellVersa1.Visible = False
                costSpellVersa2.Visible = False
                costSpellVersa3.Visible = False
                costSpellVersa4.Visible = False
                costSpellVersa5.Visible = False
                costSpellVersa6.Visible = False
                costSpellVersa7.Visible = False
                costSpellVersa8.Visible = False
                costSpellVersa9.Visible = False

                skillFrag1.Visible = True
                skillFrag2.Visible = True
                skillFrag3.Visible = True
                skillFrag4.Visible = True
                skillFrag5.Visible = True
                skillFrag6.Visible = True
                skillSpellVersa1.Visible = False
                skillSpellVersa2.Visible = False
                skillSpellVersa3.Visible = False
                skillSpellVersa4.Visible = False
                skillSpellVersa5.Visible = False
                skillSpellVersa6.Visible = False
                skillSpellVersa7.Visible = False
                skillSpellVersa8.Visible = False
                skillSpellVersa9.Visible = False

                lblFavoured.Visible = False
                costFavoured.Visible = False

                skillFrag1.Enabled = True

                If skillFlurryOfBlows.Value > 0 Then
                    skillFrag2.Enabled = True
                Else
                    skillFrag2.Enabled = False
                    skillFrag2.Value = 0
                End If

                If skillSlayParry.Value > 0 Or skillSlayParryMaster.Value > 0 Then
                    skillFrag3.Enabled = True
                Else
                    skillFrag3.Enabled = False
                    skillFrag3.Value = 0
                End If

                skillFrag4.Enabled = True
                skillFrag5.Enabled = True
                skillFrag6.Enabled = True

                lblFrag1.Text = "Trip"
                lblFrag2.Text = "Whirlwind of Blows"
                lblFrag3.Text = "Decapitate"
                lblFrag4.Text = "Battle Field Repair"
                lblFrag5.Text = "Cripple"
                lblFrag6.Text = "Dirt in the Eye"

                costFrag1.Text = 30
                costFrag2.Text = 75
                costFrag3.Text = 150
                costFrag4.Text = 30
                costFrag5.Text = 40
                costFrag6.Text = 45

                costLooting.Text = 15
                costParagon.Text = 15
                costPossum.Text = 30
                costTeacher.Text = 15
                costCreateAlcohol.Text = 25

            Case 1003 To 1005

                lblFrag1.Visible = True
                lblFrag2.Visible = True
                lblFrag3.Visible = True
                lblFrag4.Visible = True
                lblFrag5.Visible = True
                lblFrag6.Visible = False
                lblSpellVersa.Visible = False
                lblSpellVersa1.Visible = False
                lblSpellVersa2.Visible = False
                lblSpellVersa3.Visible = False
                lblSpellVersa4.Visible = False
                lblSpellVersa5.Visible = False
                lblSpellVersa6.Visible = False
                lblSpellVersa7.Visible = False
                lblSpellVersa8.Visible = False
                lblSpellVersa9.Visible = False

                costFrag1.Visible = True
                costFrag2.Visible = True
                costFrag3.Visible = True
                costFrag4.Visible = True
                costFrag5.Visible = True
                costFrag6.Visible = False
                costSpellVersa1.Visible = False
                costSpellVersa2.Visible = False
                costSpellVersa3.Visible = False
                costSpellVersa4.Visible = False
                costSpellVersa5.Visible = False
                costSpellVersa6.Visible = False
                costSpellVersa7.Visible = False
                costSpellVersa8.Visible = False
                costSpellVersa9.Visible = False

                skillFrag1.Visible = True
                skillFrag2.Visible = True
                skillFrag3.Visible = True
                skillFrag4.Visible = True
                skillFrag5.Visible = True
                skillFrag6.Visible = False
                skillSpellVersa1.Visible = False
                skillSpellVersa2.Visible = False
                skillSpellVersa3.Visible = False
                skillSpellVersa4.Visible = False
                skillSpellVersa5.Visible = False
                skillSpellVersa6.Visible = False
                skillSpellVersa7.Visible = False
                skillSpellVersa8.Visible = False
                skillSpellVersa9.Visible = False

                lblFavoured.Visible = False
                costFavoured.Visible = False

                skillFrag1.Enabled = True
                skillFrag2.Enabled = True
                skillFrag3.Enabled = True

                If skillTrapsmith.Value > 5 Then
                    skillFrag4.Enabled = True
                Else
                    skillFrag4.Enabled = False
                    skillFrag4.Value = 0
                End If

                skillFrag5.Enabled = True

                lblFrag1.Text = "Sucker Punch"
                lblFrag2.Text = "Thieves Cant"
                lblFrag3.Text = "Tumble"
                lblFrag4.Text = "Escape"
                lblFrag5.Text = "Riposte"
                lblFrag6.Text = "Blindfighter"

                costFrag1.Text = 65
                costFrag2.Text = 25
                costFrag3.Text = 65
                costFrag4.Text = 20
                costFrag5.Text = 150
                costFrag6.Text = 15

                If Job = 1003 Then costLooting.Text = 10 Else costLooting.Text = 15
                costParagon.Text = 15
                costPossum.Text = 30
                costTeacher.Text = 15
                costCreateAlcohol.Text = 25

            Case 1006 To 1008

                lblFrag1.Visible = True
                lblFrag2.Visible = True
                lblFrag3.Visible = True
                lblFrag4.Visible = True
                lblFrag5.Visible = True
                lblFrag6.Visible = True
                lblSpellVersa.Visible = True
                lblSpellVersa1.Visible = True
                lblSpellVersa2.Visible = True
                lblSpellVersa3.Visible = True
                lblSpellVersa4.Visible = True
                lblSpellVersa5.Visible = True
                lblSpellVersa6.Visible = True
                lblSpellVersa7.Visible = True
                lblSpellVersa8.Visible = True
                lblSpellVersa9.Visible = True

                costFrag1.Visible = True
                costFrag2.Visible = True
                costFrag3.Visible = True
                costFrag4.Visible = True
                costFrag5.Visible = True
                costFrag6.Visible = True
                costSpellVersa1.Visible = True
                costSpellVersa2.Visible = True
                costSpellVersa3.Visible = True
                costSpellVersa4.Visible = True
                costSpellVersa5.Visible = True
                costSpellVersa6.Visible = True
                costSpellVersa7.Visible = True
                costSpellVersa8.Visible = True
                costSpellVersa9.Visible = True

                skillFrag1.Visible = True
                skillFrag2.Visible = True
                skillFrag3.Visible = True
                skillFrag4.Visible = True
                skillFrag5.Visible = True
                skillFrag6.Visible = True
                skillSpellVersa1.Visible = True
                skillSpellVersa2.Visible = True
                skillSpellVersa3.Visible = True
                skillSpellVersa4.Visible = True
                skillSpellVersa5.Visible = True
                skillSpellVersa6.Visible = True
                skillSpellVersa7.Visible = True
                skillSpellVersa8.Visible = True
                skillSpellVersa9.Visible = True

                lblFavoured.Visible = False
                costFavoured.Visible = False

                skillFrag1.Enabled = True
                If skillSelfMut.Value > 0 Then
                    skillFrag2.Enabled = True
                Else
                    skillFrag2.Enabled = False
                    skillFrag2.Value = 0
                End If

                skillFrag3.Enabled = True
                skillFrag4.Enabled = True
                skillFrag5.Enabled = True
                skillFrag6.Enabled = True

                lblFrag1.Text = "Mortician"
                lblFrag2.Text = "Combat Wizardry"
                lblFrag3.Text = "Spell Switch"
                lblFrag4.Text = "Refocus"
                lblFrag5.Text = "Harvest"
                lblFrag6.Text = "Spell Parry"

                costFrag1.Text = 25
                costFrag2.Text = 50
                costFrag3.Text = 50
                costFrag4.Text = 30
                costFrag5.Text = 50
                costFrag6.Text = 35

                costLooting.Text = 15
                costParagon.Text = 15
                costPossum.Text = 30
                costTeacher.Text = 15
                costCreateAlcohol.Text = 25

            Case 1009 To 1010

                lblFrag1.Visible = True
                lblFrag2.Visible = True
                lblFrag3.Visible = True
                lblFrag4.Visible = True
                lblFrag5.Visible = True
                lblFrag6.Visible = True
                lblSpellVersa.Visible = False
                lblSpellVersa1.Visible = False
                lblSpellVersa2.Visible = False
                lblSpellVersa3.Visible = False
                lblSpellVersa4.Visible = False
                lblSpellVersa5.Visible = False
                lblSpellVersa6.Visible = False
                lblSpellVersa7.Visible = False
                lblSpellVersa8.Visible = False
                lblSpellVersa9.Visible = False

                costFrag1.Visible = True
                costFrag2.Visible = True
                costFrag3.Visible = True
                costFrag4.Visible = True
                costFrag5.Visible = True
                costFrag6.Visible = True
                costSpellVersa1.Visible = False
                costSpellVersa2.Visible = False
                costSpellVersa3.Visible = False
                costSpellVersa4.Visible = False
                costSpellVersa5.Visible = False
                costSpellVersa6.Visible = False
                costSpellVersa7.Visible = False
                costSpellVersa8.Visible = False
                costSpellVersa9.Visible = False

                skillFrag1.Visible = True
                skillFrag2.Visible = True
                skillFrag3.Visible = True
                skillFrag4.Visible = True
                skillFrag5.Visible = True
                skillFrag6.Visible = True
                skillSpellVersa1.Visible = False
                skillSpellVersa2.Visible = False
                skillSpellVersa3.Visible = False
                skillSpellVersa4.Visible = False
                skillSpellVersa5.Visible = False
                skillSpellVersa6.Visible = False
                skillSpellVersa7.Visible = False
                skillSpellVersa8.Visible = False
                skillSpellVersa9.Visible = False

                lblFavoured.Visible = True
                costFavoured.Visible = True

                skillFrag1.Enabled = True
                If skillFlurryOfBlows.Value > 0 Then
                    skillFrag2.Enabled = True
                Else
                    skillFrag2.Enabled = False
                    skillFrag2.Value = 0
                End If

                If skillSlayParry.Value > 0 Or skillSlayParryMaster.Value > 0 Then
                    skillFrag3.Enabled = True
                Else
                    skillFrag3.Enabled = False
                    skillFrag3.Value = 0
                End If

                skillFrag4.Enabled = True
                skillFrag5.Enabled = True
                skillFrag6.Enabled = True

                lblFrag1.Text = "Trip"
                lblFrag2.Text = "Whirlwind of Blows"
                lblFrag3.Text = "Decapitate"
                lblFrag4.Text = "Battle Field Repair"
                lblFrag5.Text = "Cripple"
                lblFrag6.Text = "Dirt in the Eye"

                costFrag1.Text = 30
                costFrag2.Text = 75
                costFrag3.Text = 150
                costFrag4.Text = 30
                costFrag5.Text = 40
                costFrag6.Text = 45

                costLooting.Text = 15
                costParagon.Text = 15
                costPossum.Text = 30
                costTeacher.Text = 15
                costCreateAlcohol.Text = 25

            Case 1011 To 1013

                lblFrag1.Visible = True
                lblFrag2.Visible = True
                lblFrag3.Visible = True
                lblFrag4.Visible = True
                lblFrag5.Visible = True
                lblFrag6.Visible = True
                lblSpellVersa.Visible = True
                lblSpellVersa1.Visible = True
                lblSpellVersa2.Visible = True
                lblSpellVersa3.Visible = True
                lblSpellVersa4.Visible = True
                lblSpellVersa5.Visible = True
                lblSpellVersa6.Visible = True
                lblSpellVersa7.Visible = True
                lblSpellVersa8.Visible = True
                lblSpellVersa9.Visible = True

                costFrag1.Visible = True
                costFrag2.Visible = True
                costFrag3.Visible = True
                costFrag4.Visible = True
                costFrag5.Visible = True
                costFrag6.Visible = True
                costSpellVersa1.Visible = True
                costSpellVersa2.Visible = True
                costSpellVersa3.Visible = True
                costSpellVersa4.Visible = True
                costSpellVersa5.Visible = True
                costSpellVersa6.Visible = True
                costSpellVersa7.Visible = True
                costSpellVersa8.Visible = True
                costSpellVersa9.Visible = True

                skillFrag1.Visible = True
                skillFrag2.Visible = True
                skillFrag3.Visible = True
                skillFrag4.Visible = True
                skillFrag5.Visible = True
                skillFrag6.Visible = True
                skillSpellVersa1.Visible = True
                skillSpellVersa2.Visible = True
                skillSpellVersa3.Visible = True
                skillSpellVersa4.Visible = True
                skillSpellVersa5.Visible = True
                skillSpellVersa6.Visible = True
                skillSpellVersa7.Visible = True
                skillSpellVersa8.Visible = True
                skillSpellVersa9.Visible = True

                lblFavoured.Visible = True
                costFavoured.Visible = True

                skillFrag1.Enabled = True
                If skillSelfMut.Value > 0 Then
                    skillFrag2.Enabled = True
                Else
                    skillFrag2.Enabled = False
                    skillFrag2.Value = 0
                End If

                skillFrag3.Enabled = True
                skillFrag4.Enabled = True
                skillFrag5.Enabled = True
                skillFrag6.Enabled = True

                lblFrag1.Text = "Mortician"
                lblFrag2.Text = "Combat Wizardry"
                lblFrag3.Text = "Spell Switch"
                lblFrag4.Text = "Refocus"
                lblFrag5.Text = "Harvest"
                lblFrag6.Text = "Spell Parry"

                costFrag1.Text = 25
                costFrag2.Text = 50
                costFrag3.Text = 50
                costFrag4.Text = 30
                costFrag5.Text = 50
                costFrag6.Text = 35

                costLooting.Text = 15
                costParagon.Text = 15
                costPossum.Text = 30
                costTeacher.Text = 15
                costCreateAlcohol.Text = 25

        End Select

        If Job < 1009 Then
            If ddlSphere1.Items.Contains("Dark") = True Then ddlSphere1.Items.Remove("Dark")
            If ddlSphere1.Items.Contains("Light") = True Then ddlSphere1.Items.Remove("Light")
            If ddlSphere1.Items.Contains("Draconic") = True Then ddlSphere1.Items.Remove("Draconic")

            If ddlSphere2.Items.Contains("Dark") = True Then ddlSphere2.Items.Remove("Dark")
            If ddlSphere2.Items.Contains("Light") = True Then ddlSphere2.Items.Remove("Light")
            If ddlSphere2.Items.Contains("Draconic") = True Then ddlSphere2.Items.Remove("Draconic")

            If ddlSphere3.Items.Contains("Dark") = True Then ddlSphere3.Items.Remove("Dark")
            If ddlSphere3.Items.Contains("Light") = True Then ddlSphere3.Items.Remove("Light")
            If ddlSphere3.Items.Contains("Draconic") = True Then ddlSphere3.Items.Remove("Draconic")
        ElseIf (Job = 1009 Or Job = 1011) Then
            If ddlSphere1.Items.Contains("Dark") = False Then ddlSphere1.Items.Add("Dark")
            If ddlSphere1.Items.Contains("Light") = True Then ddlSphere1.Items.Remove("Light")
            If ddlSphere1.Items.Contains("Draconic") = True Then ddlSphere1.Items.Remove("Draconic")

            If ddlSphere2.Items.Contains("Dark") = False Then ddlSphere2.Items.Add("Dark")
            If ddlSphere2.Items.Contains("Light") = True Then ddlSphere2.Items.Remove("Light")
            If ddlSphere2.Items.Contains("Draconic") = True Then ddlSphere2.Items.Remove("Draconic")

            If ddlSphere3.Items.Contains("Dark") = False Then ddlSphere3.Items.Add("Dark")
            If ddlSphere3.Items.Contains("Light") = True Then ddlSphere3.Items.Remove("Light")
            If ddlSphere3.Items.Contains("Draconic") = True Then ddlSphere3.Items.Remove("Draconic")
        ElseIf (Job = 1010 Or Job = 1012) Then
            If ddlSphere1.Items.Contains("Light") = False Then ddlSphere1.Items.Add("Light")
            If ddlSphere1.Items.Contains("Dark") = True Then ddlSphere1.Items.Remove("Dark")
            If ddlSphere1.Items.Contains("Draconic") = True Then ddlSphere1.Items.Remove("Draconic")

            If ddlSphere2.Items.Contains("Light") = False Then ddlSphere2.Items.Add("Light")
            If ddlSphere2.Items.Contains("Dark") = True Then ddlSphere2.Items.Remove("Dark")
            If ddlSphere2.Items.Contains("Draconic") = True Then ddlSphere2.Items.Remove("Draconic")

            If ddlSphere3.Items.Contains("Light") = False Then ddlSphere3.Items.Add("Light")
            If ddlSphere3.Items.Contains("Dark") = True Then ddlSphere3.Items.Remove("Dark")
            If ddlSphere3.Items.Contains("Draconic") = True Then ddlSphere3.Items.Remove("Draconic")
        ElseIf Job = 1013 Then
            If ddlSphere1.Items.Contains("Draconic") = False Then ddlSphere1.Items.Add("Draconic")
            If ddlSphere1.Items.Contains("Dark") = True Then ddlSphere1.Items.Remove("Dark")
            If ddlSphere1.Items.Contains("Draconic") = True Then ddlSphere1.Items.Remove("Light")

            If ddlSphere2.Items.Contains("Draconic") = False Then ddlSphere2.Items.Add("Draconic")
            If ddlSphere2.Items.Contains("Dark") = True Then ddlSphere2.Items.Remove("Dark")
            If ddlSphere2.Items.Contains("Draconic") = True Then ddlSphere2.Items.Remove("Light")

            If ddlSphere3.Items.Contains("Draconic") = False Then ddlSphere3.Items.Add("Draconic")
            If ddlSphere3.Items.Contains("Dark") = True Then ddlSphere3.Items.Remove("Dark")
            If ddlSphere3.Items.Contains("Draconic") = True Then ddlSphere3.Items.Remove("Light")
        End If

        If ddlSphere1.SelectedItem = "Dark" Or ddlSphere1.SelectedItem = "Light" Or ddlSphere1.SelectedItem = "Draconic" Then
            ddlSphere2.Items.Remove(ddlSphere1.SelectedItem)
            ddlSphere3.Items.Remove(ddlSphere1.SelectedItem)
        ElseIf ddlSphere2.SelectedItem = "Dark" Or ddlSphere2.SelectedItem = "Light" Or ddlSphere2.SelectedItem = "Draconic" Then
            ddlSphere3.Items.Remove(ddlSphere2.SelectedItem)
        End If

    End Sub

    Public Sub DependCheck()

        If skillReadMagic.Value > 0 Then
            skillCreateScroll.Enabled = True
        Else
            skillCreateScroll.Value = 0
            skillCreateScroll.Enabled = False
        End If

        If skillAlchemy.Value = 10 Then
            skillChemistry.Enabled = True
        Else
            skillChemistry.Value = 0
            skillChemistry.Enabled = False
        End If

        If skillBlacksmith.Value = 10 Then
            skillArtifice.Enabled = True
        Else
            skillArtifice.Value = 0
            skillArtifice.Enabled = False
        End If

        If skillAnatomy.Value > 0 Then
            skillFirstAid.Enabled = True
        Else
            skillFirstAid.Enabled = False
            skillFirstAid.Value = 0
        End If

        If skillFirstAid.Value > 0 Then
            skillPhysician.Enabled = True
        Else
            skillPhysician.Enabled = False
            skillPhysician.Value = 0
        End If

        If skillReadAndWrite.Value > 0 Then
            skillReadMagic.Enabled = True
        Else
            skillReadMagic.Enabled = False
            skillReadMagic.Value = 0
        End If


        If skillReadMagic.Value > 0 Then
            skillReadMagicAvd.Enabled = True
        Else
            skillReadMagicAvd.Enabled = False
            skillReadMagicAvd.Value = 0
        End If


        If skillReadMagicAvd.Value > 0 Then
            skillReadMagicRitual.Enabled = True
        Else
            skillReadMagicRitual.Enabled = False
            skillReadMagicRitual.Value = 0
        End If

        'Skill212 - Spell Slot Level 1

        If OpenSave = False Then

            If skillSphere1.Value > 0 Then
                skillSpell1.Enabled = True
                If skillSpell1.Value - skillSpell2.Value = 2 And skillSpell9.Value < 5 Then skillSpell1.Enabled = False
                ddlPyramid.Enabled = True
            Else
                skillSpell1.Enabled = False
                skillSpell1.Value = 0

                ddlPyramid.Enabled = False
                ddlPyramid.SelectedIndex = 0
            End If


            If skillSpell1.Value > 0 Then
                skillSpell2.Enabled = True
                skillSpellVersa1.Enabled = True
                skillSpellVersa1.Maximum = skillSpell1.Value
                If skillSpell2.Value - skillSpell3.Value = 2 And skillSpell9.Value < 5 Then skillSpell2.Enabled = False
            Else
                skillSpell2.Enabled = False
                skillSpell2.Value = 0

                skillSpellVersa1.Enabled = False
                skillSpellVersa1.Value = 0
            End If


            If skillSpell2.Value > 0 Then
                skillSpell3.Enabled = True
                skillSpellVersa2.Enabled = True
                skillSpellVersa2.Maximum = skillSpell2.Value
                If skillSpell3.Value - skillSpell4.Value = 2 And skillSpell9.Value < 5 Then skillSpell3.Enabled = False
            Else
                skillSpell3.Enabled = False
                skillSpell3.Value = 0

                skillSpellVersa2.Enabled = False
                skillSpellVersa2.Value = 0
            End If


            If skillSpell3.Value > 0 Then
                skillSpell4.Enabled = True
                skillSpellVersa3.Enabled = True
                skillSpellVersa3.Maximum = skillSpell3.Value
                If skillSpell4.Value - skillSpell5.Value = 2 And skillSpell9.Value < 5 Then skillSpell4.Enabled = False
            Else
                skillSpell4.Enabled = False
                skillSpell4.Value = 0

                skillSpellVersa3.Enabled = False
                skillSpellVersa3.Value = 0
            End If

            If skillSpell4.Value > 0 AndAlso skillReadMagicAvd.Value > 0 Then
                skillSpell5.Enabled = True
                skillSpellVersa4.Enabled = True
                skillSpellVersa4.Maximum = skillSpell4.Value
                If skillSpell5.Value - skillSpell4.Value = 2 And skillSpell9.Value < 5 Then skillSpell5.Enabled = False
            Else
                skillSpell5.Enabled = False
                skillSpell5.Value = 0

                skillSpellVersa4.Enabled = False
                skillSpellVersa4.Value = 0
            End If


            If skillSpell5.Value > 0 Then
                skillSpell6.Enabled = True
                skillSpellVersa5.Enabled = True
                skillSpellVersa5.Maximum = skillSpell5.Value
                If skillSpell6.Value - skillSpell5.Value = 2 And skillSpell9.Value < 5 Then skillSpell6.Enabled = False
            Else
                skillSpell6.Enabled = False
                skillSpell6.Value = 0

                skillSpellVersa5.Enabled = False
                skillSpellVersa5.Value = 0
            End If


            If skillSpell6.Value > 0 Then
                skillSpell7.Enabled = True
                skillSpellVersa6.Enabled = True
                skillSpellVersa6.Maximum = skillSpell6.Value
                If skillSpell7.Value - skillSpell6.Value = 2 And skillSpell9.Value < 5 Then skillSpell7.Enabled = False
            Else
                skillSpell7.Enabled = False
                skillSpell7.Value = 0

                skillSpellVersa6.Enabled = False
                skillSpellVersa6.Value = 0
            End If


            If skillSpell7.Value > 0 Then
                skillSpell8.Enabled = True
                skillSpellVersa7.Enabled = True
                skillSpellVersa7.Maximum = skillSpell7.Value
                If skillSpell8.Value - skillSpell7.Value = 2 And skillSpell9.Value < 5 Then skillSpell8.Enabled = False
            Else
                skillSpell8.Enabled = False
                skillSpell8.Value = 0

                skillSpellVersa7.Enabled = False
                skillSpellVersa7.Value = 0
            End If


            If skillSpell8.Value > 0 Then
                skillSpell9.Enabled = True
                skillSpellVersa8.Enabled = True
                skillSpellVersa8.Maximum = skillSpell8.Value
                If skillSpell9.Value - skillSpell8.Value = 2 And skillSpell9.Value < 5 Then skillSpell9.Enabled = False
            Else
                skillSpell9.Enabled = False
                skillSpell9.Value = 0

                skillSpellVersa8.Enabled = False
                skillSpellVersa8.Value = 0
            End If


            If skillSpell9.Value > 0 AndAlso skillReadMagicRitual.Value > 0 Then
                skillSpellRitual.Enabled = True
                skillSpellVersa9.Enabled = True
                skillSpellVersa9.Maximum = skillSpell9.Value
            Else
                skillSpellRitual.Enabled = False
                skillSpellRitual.Value = 0

                skillSpellVersa9.Enabled = False
                skillSpellVersa9.Enabled = 0
            End If
        End If

        If skillReadMagic.Value > 0 Then
            skillSphere1.Enabled = True
        Else
            skillSphere1.Enabled = False
            skillSphere1.Value = 0
        End If


        If skillSphere1.Value > 0 Then
            skillSphere2.Enabled = True
        Else
            skillSphere2.Enabled = False
            skillSphere2.Value = 0
        End If

        If skillSphere2.Value > 0 Then
            skillSphere3.Enabled = True
        Else
            skillSphere3.Enabled = False
            skillSphere3.Value = 0
        End If

        If skillSpellRitual.Value > 0 Then
            skillAdvRitual.Enabled = True
        Else
            skillAdvRitual.Enabled = False
            skillAdvRitual.Value = 0
        End If

        If skillAmbidexterity.Value > 0 Then
            skillFlorentine.Enabled = True
        Else
            skillFlorentine.Value = 0
            skillFlorentine.Enabled = False
        End If

        If skillReadMagic.Value > 0 AndAlso SPhere700 = True Then
            skillEleAttunement.Enabled = True
        Else
            skillEleAttunement.Value = 0
            skillEleAttunement.Enabled = False
        End If

        If skillSpecGroup.Value > 0 Or skillSpecSpecific.Value > 0 Then
            skillSlayParry.Enabled = True
            skillSlayParry.Maximum = skillSpecGroup.Value + skillSpecSpecific.Value - skillSlayParryMaster.Value
        Else
            skillSlayParry.Value = 0
            skillSlayParry.Enabled = False
        End If

        If skillSimpleProf.Value > 0 Or skillMedProf.Value > 0 Or skillLargeProf.Value > 0 Then
            skillSpecGroup.Enabled = True
        Else
            skillSpecGroup.Value = 0
            skillSpecGroup.Enabled = False
        End If

        If skillSimpleProf.Value > 0 Or skillMedProf.Value > 0 Or skillLargeProf.Value > 0 Then
            skillSpecSpecific.Enabled = True
        Else
            skillSpecSpecific.Value = 0
            skillSpecSpecific.Enabled = False
        End If

        If skillSimpleProf.Value > 0 Or skillMedProf.Value > 0 Or skillLargeProf.Value > 0 Then
            skillCritSpecific.Enabled = True
        Else
            skillCritSpecific.Value = 0
            skillCritSpecific.Enabled = False
        End If

        If skillSimpleProf.Value > 0 Or skillMedProf.Value > 0 Or skillLargeProf.Value > 0 Then
            skillCritGroup.Enabled = True
        Else
            skillCritGroup.Value = 0
            skillCritGroup.Enabled = False
        End If

        If skillCritSpecific.Value > 0 Or skillCritGroup.Value > 0 Or Job = 1003 AndAlso skillJob1.Value > 0 Then
            skillDodge.Enabled = True
        Else
            skillDodge.Value = 0
            skillDodge.Enabled = False
        End If

        If skillCritSpecific.Value > 0 Or skillCritGroup.Value > 0 Then
            skillExecute.Enabled = True
            skillExecute.Maximum = skillCritSpecific.Value + skillCritGroup.Value - skillExecuteMaster.Value
        Else
            skillExecute.Value = 0
            skillExecute.Enabled = False
        End If

        If skillSpecGroup.Value > 0 Then
            skillSlayParryMaster.Enabled = True
            If skillSlayParry.Value > skillSpecSpecific.Value Then
                skillSlayParryMaster.Maximum = skillSpecGroup.Value + skillSpecSpecific.Value - skillSlayParry.Value
            Else
                skillSlayParryMaster.Maximum = skillSpecGroup.Value
            End If
        Else
            skillSlayParryMaster.Value = 0
            skillSlayParryMaster.Enabled = False
        End If

        If skillCritGroup.Value > 0 Then
            skillExecuteMaster.Enabled = True
            If skillExecute.Value > skillCritSpecific.Value Then
                skillExecuteMaster.Maximum = skillCritGroup.Value + skillCritSpecific.Value - skillExecute.Value
            Else
                skillExecuteMaster.Maximum = skillCritGroup.Value
            End If
        Else
            skillExecuteMaster.Value = 0
            skillExecuteMaster.Enabled = False
        End If

        If skillSpecGroup.Value = 0 Then
            ddlSpecGroup.Enabled = False
        Else
            ddlSpecGroup.Enabled = True
        End If

        If skillSpecSpecific.Value = 0 Then
            ddlSpecSpecific.Enabled = False
        Else
            ddlSpecSpecific.Enabled = True
        End If

        If skillSlayParry.Value = 0 Then
            ddlSlayParryWeapon.Enabled = False
        Else
            ddlSlayParryWeapon.Enabled = True
        End If

        If skillSlayParryMaster.Value = 0 Then
            ddlSlayParryMasterWeapon.Enabled = False
        Else
            ddlSlayParryMasterWeapon.Enabled = True
        End If

        If skillExoticProf.Value = 0 Then
            ddlExoticWeapon.Enabled = False
        Else
            ddlExoticWeapon.Enabled = True
        End If

        If skillCritSpecific.Value = 0 Then
            ddlCritSpecificWeapon.Enabled = False
        Else
            ddlCritSpecificWeapon.Enabled = True
        End If

        If skillCritGroup.Value = 0 Then
            ddlCritGroup.Enabled = False
        Else
            ddlCritGroup.Enabled = True
        End If

        If skillExecute.Value = 0 Then
            ddlExecute.Enabled = False
        Else
            ddlExecute.Enabled = True
        End If

        If skillExecuteMaster.Value = 0 Then
            ddlExecuteMaster.Enabled = False
        Else
            ddlExecuteMaster.Enabled = True
        End If

        If Level >= 3 Then
            skillJob1.Enabled = True
        Else : skillJob1.Enabled = False
            skillJob1.Value = 0
        End If

        If Level >= 6 AndAlso skillJob1.Value > 0 Then
            skillJob2.Enabled = True
        Else : skillJob2.Enabled = False
            skillJob2.Value = 0
        End If

        If Level >= 9 AndAlso skillJob2.Value > 0 Then
            skillJob3.Enabled = True
        Else
            skillJob3.Enabled = False
            skillJob3.Value = 0
        End If

        If Level >= 12 AndAlso skillJob3.Value > 0 Then
            skillJob4.Enabled = True
        Else
            skillJob4.Enabled = False
            skillJob4.Value = 0
        End If

    End Sub

    Public Sub SphereSets()
        If skillSphere1.Value > 0 Then
            ddlSphere1.Enabled = True
        Else
            ddlSphere1.SelectedIndex = -1
            ddlSphere1.Enabled = False
        End If

        If skillSphere2.Value > 0 Then
            ddlSphere2.Enabled = True
        Else
            ddlSphere2.SelectedIndex = -1
            ddlSphere2.Enabled = False
        End If

        If skillSphere3.Value > 0 Then
            ddlSphere3.Enabled = True
        Else
            ddlSphere3.SelectedIndex = -1
            ddlSphere3.Enabled = False
        End If


    End Sub
    Public Sub SetSpheres()
        Select Case ddlSphere1.SelectedItem
            Case "Elemental"
                SPhere700 = True
            Case "Healing"
                SPhere701 = True
            Case "Nature"
                SPhere702 = True
            Case "Psionics"
                SPhere703 = True
            Case "Protections"
                SPhere704 = True
            Case "Wytchcraft"
                SPhere705 = True
            Case "Dark"
                SPhere705 = True
            Case "Light"
                SPhere705 = True
            Case "Draconic"
                SPhere705 = True
            Case Else
        End Select

        Select Case ddlSphere2.SelectedItem
            Case "Elemental"
                SPhere700 = True
            Case "Healing"
                SPhere701 = True
            Case "Nature"
                SPhere702 = True
            Case "Psionics"
                SPhere703 = True
            Case "Protections"
                SPhere704 = True
            Case "Wytchcraft"
                SPhere705 = True
            Case "Dark"
                SPhere705 = True
            Case "Light"
                SPhere705 = True
            Case "Draconic"
                SPhere705 = True
            Case Else
        End Select

        Select Case ddlSphere3.SelectedItem
            Case "Elemental"
                SPhere700 = True
            Case "Healing"
                SPhere701 = True
            Case "Nature"
                SPhere702 = True
            Case "Psionics"
                SPhere703 = True
            Case "Protections"
                SPhere704 = True
            Case "Wytchcraft"
                SPhere705 = True
            Case "Dark"
                SPhere705 = True
            Case "Light"
                SPhere705 = True
            Case "Draconic"
                SPhere705 = True
            Case Else
        End Select
    End Sub

    Public Sub WeaponLocks()
        If skillSlayParry.Value > 0 Then
            ddlSlayParryWeapon.Enabled = True
        Else
            ddlSlayParryWeapon.SelectedIndex = -1
            ddlSlayParryWeapon.Enabled = False
        End If

        If skillSlayParryMaster.Value > 0 Then
            ddlSlayParryMasterWeapon.Enabled = True
        Else
            ddlSlayParryMasterWeapon.SelectedIndex = -1
            ddlSlayParryMasterWeapon.Enabled = False
        End If

        If skillSpecGroup.Value > 0 Then
            ddlSpecGroup.Enabled = True
        Else
            ddlSpecGroup.SelectedIndex = -1
            ddlSpecGroup.Enabled = False
        End If

        If skillSpecSpecific.Value > 0 Then
            ddlSpecSpecific.Enabled = True
        Else
            ddlSpecSpecific.SelectedIndex = -1
            ddlSpecSpecific.Enabled = False
        End If

        If skillExoticProf.Value > 0 Then
            ddlExoticWeapon.Enabled = True
        Else
            ddlExoticWeapon.SelectedIndex = -1
            ddlExoticWeapon.Enabled = False
        End If

        If skillCritSpecific.Value > 0 Then
            ddlCritSpecificWeapon.Enabled = True
        Else
            ddlCritSpecificWeapon.SelectedIndex = -1
            ddlCritSpecificWeapon.Enabled = False
        End If

        If skillCritGroup.Value > 0 Then
            ddlCritGroup.Enabled = True
        Else
            ddlCritGroup.SelectedIndex = -1
            ddlCritGroup.Enabled = False
        End If

        If skillExecute.Value > 0 Then
            ddlExecute.Enabled = True
        Else
            ddlExecute.SelectedIndex = -1
            ddlExecute.Enabled = False
        End If

        If skillExecuteMaster.Value > 0 Then
            ddlExecuteMaster.Enabled = True
        Else
            ddlExecuteMaster.SelectedIndex = -1
            ddlExecuteMaster.Enabled = False
        End If

    End Sub
    Public Sub SetJobSkills()

        If chkVocation.Checked = True Then
            Select Case ddlVocation.SelectedItem
                Case "Archer"
                    Job = 1100
                Case "Battle Mage"
                    Job = 1101
                Case "Brew Master"
                    Job = 1102
                Case "Stalwart"
                    Job = 1103
                Case "Undead Hunter"
                    Job = 1104
                Case "Shaman"
                    Job = 1105
                Case "Artisan"
                    Job = 1106
                Case "Swashbuckler"
                    Job = 1107
            End Select
            JobName = ddlVocation.SelectedItem
        End If

        Select Case Job
            Case 1000
                lblJob1.Text = "Hamstring"
                lblJob2.Text = "Head-butt"
                lblJob3.Text = "Dismember"
                lblJob4.Text = "Razor's Edge"
            Case 1001
                lblJob1.Text = "Dextoxify"
                lblJob2.Text = "Trailblazing"
                lblJob3.Text = "Nature's Grasp"
                lblJob4.Text = "Call of the Hunt"
            Case 1002
                lblJob1.Text = "Burn Slot"
                lblJob2.Text = "Scroll Harvest"
                lblJob3.Text = "Weapon Break"
                lblJob4.Text = "Weapon Conduit"
            Case 1003
                lblJob1.Text = "Feint"
                lblJob2.Text = "Duplicate Key"
                lblJob3.Text = "Dim"
                lblJob4.Text = "Passwall"
            Case 1004
                lblJob1.Text = "Shiv"
                lblJob2.Text = "Silent Strike"
                lblJob3.Text = "Spirit Sever"
                lblJob4.Text = "Penetration"
            Case 1005
                lblJob1.Text = "Witch Mark"
                lblJob2.Text = "Twist of Tongue"
                lblJob3.Text = "Karmic Richochet"
                lblJob4.Text = "Counter Magic"
            Case 1006
                lblJob1.Text = "Identify Magic Item"
                lblJob2.Text = "Mana Harvest"
                lblJob3.Text = "Create Familiar"
                lblJob4.Text = "Power Nexus"
            Case 1007
                lblJob1.Text = "Create Grove"
                lblJob2.Text = "Forest Meld"
                lblJob3.Text = "Totem"
                lblJob4.Text = "Henge"
            Case 1008
                lblJob1.Text = "Song-Aversion"
                lblJob2.Text = "Song-Love"
                lblJob3.Text = "Song-Intermission"
                lblJob4.Text = "Song-Heroism"
            Case 1009
                lblJob1.Text = "Harbinger's Blade"
                lblJob2.Text = "Unholy Ring"
                lblJob3.Text = "Unholy Symbol"
                lblJob4.Text = "Headpiece"
            Case 1010
                lblJob1.Text = "Defender"
                lblJob2.Text = "Holy Ring"
                lblJob3.Text = "Holy Symbol"
                lblJob4.Text = "Headpiece"
            Case 1011
                lblJob1.Text = "Unholy Altar"
                lblJob2.Text = "Sacred Bond"
                lblJob3.Text = "Sacred Vessel"
                lblJob4.Text = "Church"
            Case 1012
                lblJob1.Text = "Holy Altar"
                lblJob2.Text = "Sacred Bond"
                lblJob3.Text = "Sacred Vessel"
                lblJob4.Text = "Church"
            Case 1013
                lblJob1.Text = "Draconic Shrine"
                lblJob2.Text = "Draconic Covenant"
                lblJob3.Text = "Draconic Trove"
                lblJob4.Text = "Temple"
            Case 1100
                lblJob1.Text = "Arrow Dodge"
                lblJob2.Text = "Stand and Deliver"
                lblJob3.Text = "Maim"
                lblJob4.Text = "Death Arrow"
            Case 1101
                lblJob1.Text = "Talisman"
                lblJob2.Text = "Maximize"
                lblJob3.Text = "Twin Spell"
                lblJob4.Text = "Wizard Staff"
                skillJob4.Maximum = 1
            Case 1102
                lblJob1.Text = "Iron Gut"
                skillJob1.Maximum = 1
                lblJob2.Text = "Mixologist"
                lblJob3.Text = "Fire Breathing"
                lblJob4.Text = "Drunken Master"
            Case 1103
                lblJob1.Text = "Shield Parry"
                lblJob2.Text = "Conviction"
                lblJob3.Text = "Fortitude"
                lblJob4.Text = "Imbue Shield"
            Case 1104
                lblJob1.Text = "Hunter's Focus"
                lblJob2.Text = "Hunter's Attrition"
                lblJob3.Text = "Crystal of Light"
                lblJob4.Text = "Final Rest"
            Case 1105
                lblJob1.Text = "Rite of Weaving"
                lblJob2.Text = "Rite of War"
                lblJob3.Text = "Rite of Vision"
                lblJob4.Text = "Rite of the Monolith"
                skillJob4.Maximum = 1
            Case 1106
                lblJob1.Text = "Treasure Hunter"
                lblJob2.Text = "Bribe"
                lblJob3.Text = "Magnum Opus"
                lblJob4.Text = "Vault"
            Case 1107
                lblJob1.Text = "Finesse"
                lblJob2.Text = "En Garde!"
                lblJob3.Text = "Prise de Fer"
                lblJob4.Text = "Aegis"
        End Select
    End Sub

    Public Sub RaceBonus()
        NoBod = True
        NoStr = True
        Select Case Race
            Case 800
                lblRacial2.Text = "Ancestor’s Wisdom"
                lblRacialAuto.Text = "Eyes of the Mother"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 801
                lblRacial2.Text = "Spite Blood"
                lblRacialAuto.Text = "Natural Chemists"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False
            Case 802
                lblRacial2.Text = "Berserker Rage"
                lblRacialAuto.Text = "Resist Cold"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 1
                skillStr.Maximum = 1
                NoBod = False
                NoStr = False
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 803
                lblRacial2.Text = "Stoneskin"
                lblRacialAuto.Text = "Alternate Healing"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 2
                skillStr.Maximum = 0
                NoBod = False
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 804
                lblRacial2.Text = "Resist Psionics"
                lblRacialAuto.Text = "Magical Aptitude"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 805
                lblRacial2.Text = "Racial Dodge"
                lblRacialAuto.Text = "Taunt"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 806
                lblRacial2.Text = ""
                lblRacialAuto.Text = "Character Point Bonus   +50CP"
                skillRacial2.Maximum = 0
                skillBPB.Maximum = 1
                skillStr.Maximum = 0
                NoBod = False
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False
                lblRacial2.Visible = False
                costRacial2.Visible = False
                skillRacial2.Visible = False

            Case 807
                lblRacial2.Text = ""
                lblRacialAuto.Text = "Resist Toxin"
                skillRacial2.Maximum = 0
                skillBPB.Maximum = 3
                skillStr.Maximum = 0
                NoBod = False
                lblRacial2.Visible = False
                costRacial2.Visible = False
                skillRacial2.Visible = False
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 808
                lblRacial2.Text = "Orcish Const."
                lblRacialAuto.Text = "Immune to Fear"
                skillRacial2.Maximum = 1
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True

            Case 809
                lblRacial2.Text = "Cat-Like Reflexes"
                lblRacialAuto.Text = "Natural Claws"
                lblRacialAuto.Visible = True
                listRacial.Visible = True
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0

            Case 810
                lblRacial2.Text = "Nature's Cache"
                lblRacialAuto.Text = "Chosen Enemy"
                lblRacialAuto.Visible = True
                listRacial.Visible = True
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 1
                skillStr.Maximum = 0
                NoBod = False

            Case 811
                lblRacial2.Text = "Charm Break"
                lblRacialAuto.Text = "Lust for Life"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 812
                lblRacial2.Text = "Create Goggles"
                lblRacialAuto.Text = "Spirit Anchor"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 813
                lblRacial2.Text = "Resist Magic"
                lblRacialAuto.Text = "Destroy Light"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 1
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False
                NoStr = False

            Case 814
                lblRacial2.Text = "Reflect Divine"
                lblRacialAuto.Text = "Natural Threshold"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 815
                lblRacial2.Text = "Unmasked"
                lblRacialAuto.Text = "Permanent Non-Detection"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 816
                lblRacial2.Text = "Companion"
                lblRacialAuto.Text = "Forest Revival"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 817
                lblRacial2.Text = "Clobber"
                lblRacialAuto.Text = "Simple Weapon Bonus Damage"
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 818
                lblRacial2.Text = "Endurance"
                lblRacialAuto.Text = "Resist Fire"
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 819
                lblRacial2.Text = "Maintenance"
                lblRacialAuto.Text = "Tinkering"
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 820
                lblRacial2.Text = "Amorphic Mucus"
                lblRacialAuto.Text = "Learning Aptitude - Shenanigans"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 821
                lblRacial2.Text = "Memories in Flesh"
                lblRacialAuto.Text = "Scion of Suffering"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 1
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False
                NoBod = False

            Case 822
                lblRacial2.Text = "KABOOM!"
                lblRacialAuto.Text = "Sap"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 823
                lblRacial2.Text = "Fae Ward"
                lblRacialAuto.Text = "Enhanced Strength - Strength +1"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 4
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False
                NoStr = False

            Case 824
                lblRacial2.Text = "Ogre Smash"
                lblRacialAuto.Text = "Ogre Constitution"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 825
                lblRacial2.Text = "Spirit Skinning"
                lblRacialAuto.Text = "Dual Race"
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 826
                lblRacial2.Text = "Magic Echo"
                lblRacialAuto.Text = "Formless Casting"
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 827
                lblRacial2.Text = "Tongue Pierce"
                lblRacialAuto.Text = "Seal Pores"
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 828
                lblRacial2.Text = "Endure Fire"
                lblRacialAuto.Text = "Volcanic Skin"
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 0
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False

            Case 829
                lblRacial2.Text = "Natural Hide"
                lblRacialAuto.Text = "Sense Undead"
                lblRacial2.Visible = True
                costRacial2.Visible = True
                skillRacial2.Visible = True
                skillRacial2.Maximum = 10
                skillBPB.Maximum = 0
                skillStr.Maximum = 1
                lblRacialAuto.Visible = False
                costRacialAuto.Visible = False
                skillRacialAuto.Visible = False
                listRacial.Visible = False
                NoStr = False

        End Select

        If skillRacial2.Value + skillBPB.Value + skillStr.Value = Int((Level + 1) / 2) Then
            skillRacial2.Maximum = skillRacial2.Value
            skillBPB.Maximum = skillBPB.Value
            skillStr.Maximum = skillStr.Value
        ElseIf skillRacial2.Value + skillBPB.Value + skillStr.Value > Int((Level + 1) / 2) Then
            If skillRacial2.Value > 0 Then skillRacial2.Value = skillRacial2.Value - 1
            If skillBPB.Value > 0 Then skillBPB.Value = skillBPB.Value - 1
            If skillStr.Value > 0 Then skillStr.Value = skillStr.Value - 1
        End If

        If NoBod = True Then skillBPB.Visible = False Else skillBPB.Visible = True
        If NoBod = True Then lblBPB.Visible = False Else lblBPB.Visible = True
        If NoBod = True Then costBPB.Visible = False Else costBPB.Visible = True
        If NoStr = True Then skillStr.Visible = False Else skillStr.Visible = True
        If NoStr = True Then lblStr.Visible = False Else lblStr.Visible = True
        If NoStr = True Then costStr.Visible = False Else costStr.Visible = True
    End Sub
#End Region

#Region "Build Lists"
    Public Sub BuildSpecGroupList()
        If ddlSpecGroup.SelectedIndex = -1 Then
            ddlSpecGroup.Items.Clear()
        End If

        If skillSimpleProf.Value > 0 AndAlso ddlSpecGroup.Items.Contains("Simple") = False Then
            ddlSpecGroup.Items.Add("Simple")
        End If
        If skillMedProf.Value > 0 AndAlso ddlSpecGroup.Items.Contains("Medium") = False Then
            ddlSpecGroup.Items.Add("Medium")
        End If
        If skillLargeProf.Value > 0 AndAlso ddlSpecGroup.Items.Contains("Large") = False Then
            ddlSpecGroup.Items.Add("Large")
        End If

    End Sub
    Public Sub BuildSpecSpecificList()
        If ddlSpecSpecific.SelectedIndex = -1 Then
            ddlSpecSpecific.Items.Clear()
            If skillSimpleProf.Value > 0 Then
                ddlSpecSpecific.Items.Add("Dagger/Knife")
                ddlSpecSpecific.Items.Add("Staff")
                ddlSpecSpecific.Items.Add("Club")
                ddlSpecSpecific.Items.Add("Thrown")
                ddlSpecSpecific.Items.Add("Hand-to-Hand")

            End If
            If skillMedProf.Value > 0 Then
                ddlSpecSpecific.Items.Add("Sword")
                ddlSpecSpecific.Items.Add("Scimitar")
                ddlSpecSpecific.Items.Add("Mace")
                ddlSpecSpecific.Items.Add("Hammer")
                ddlSpecSpecific.Items.Add("1H Spear")
                ddlSpecSpecific.Items.Add("1H Axe")
                ddlSpecSpecific.Items.Add("Javelin")
                ddlSpecSpecific.Items.Add("Arrow")
                ddlSpecSpecific.Items.Add("Claw")

            End If
            If skillLargeProf.Value > 0 Then
                ddlSpecSpecific.Items.Add("2H Greatsword")
                ddlSpecSpecific.Items.Add("2H Polearm")
                ddlSpecSpecific.Items.Add("2H Axe")
                ddlSpecSpecific.Items.Add("Bolt")
                ddlSpecSpecific.Items.Add("2H Club")
                ddlSpecSpecific.Items.Add("2H Mace")
            End If

            If skillExoticProf.Value > 0 AndAlso ddlExoticWeapon.SelectedIndex <> -1 Then
                ddlSpecSpecific.Items.Add(ddlExoticWeapon.SelectedItem)
            End If
        End If
    End Sub
    Public Sub BuildSlayParryList()
        If ddlSlayParryWeapon.SelectedIndex = -1 Then
            If ddlSpecSpecific.SelectedIndex <> -1 AndAlso ddlSpecGroup.SelectedIndex <> -1 Then
                ddlSlayParryWeapon.Items.Clear()
                ddlSlayParryWeapon.Items.Add(ddlSpecSpecific.SelectedItem)
                Select Case ddlSpecGroup.SelectedItem
                    Case "Simple"
                        ddlSlayParryWeapon.Items.Add("Dagger/Knife")
                        ddlSlayParryWeapon.Items.Add("Staff")
                        ddlSlayParryWeapon.Items.Add("Club")
                        ddlSlayParryWeapon.Items.Add("Thrown")
                        ddlSlayParryWeapon.Items.Add("Hand-to-Hand")
                    Case "Medium"
                        ddlSlayParryWeapon.Items.Add("Sword")
                        ddlSlayParryWeapon.Items.Add("Scimitar")
                        ddlSlayParryWeapon.Items.Add("Mace")
                        ddlSlayParryWeapon.Items.Add("Hammer")
                        ddlSlayParryWeapon.Items.Add("1H Spear")
                        ddlSlayParryWeapon.Items.Add("1H Axe")
                        ddlSlayParryWeapon.Items.Add("Javelin")
                        ddlSlayParryWeapon.Items.Add("Arrow")
                        ddlSlayParryWeapon.Items.Add("Claw")

                    Case "Large"
                        ddlSlayParryWeapon.Items.Add("2H Greatsword")
                        ddlSlayParryWeapon.Items.Add("2H Polearm")
                        ddlSlayParryWeapon.Items.Add("2H Axe")
                        ddlSlayParryWeapon.Items.Add("Bolt")
                        ddlSlayParryWeapon.Items.Add("2H Club")
                        ddlSlayParryWeapon.Items.Add("2H Mace")

                    Case Else
                End Select

            ElseIf ddlSpecSpecific.SelectedIndex <> -1 AndAlso ddlSpecGroup.SelectedIndex = -1 Then
                ddlSlayParryWeapon.Items.Clear()
                ddlSlayParryWeapon.Items.Add(ddlSpecSpecific.SelectedItem)
            ElseIf ddlSpecSpecific.SelectedIndex = -1 AndAlso ddlSpecGroup.SelectedIndex <> -1 Then
                ddlSlayParryWeapon.Items.Clear()
                Select Case ddlSpecGroup.SelectedItem
                    Case "Simple"
                        ddlSlayParryWeapon.Items.Add("Dagger/Knife")
                        ddlSlayParryWeapon.Items.Add("Staff")
                        ddlSlayParryWeapon.Items.Add("Club")
                        ddlSlayParryWeapon.Items.Add("Thrown")
                        ddlSlayParryWeapon.Items.Add("Hand-to-Hand")
                    Case "Medium"
                        ddlSlayParryWeapon.Items.Add("Sword")
                        ddlSlayParryWeapon.Items.Add("Scimitar")
                        ddlSlayParryWeapon.Items.Add("Mace")
                        ddlSlayParryWeapon.Items.Add("Hammer")
                        ddlSlayParryWeapon.Items.Add("1H Spear")
                        ddlSlayParryWeapon.Items.Add("1H Axe")
                        ddlSlayParryWeapon.Items.Add("Javelin")
                        ddlSlayParryWeapon.Items.Add("Arrow")
                        ddlSlayParryWeapon.Items.Add("Claw")

                    Case "Large"
                        ddlSlayParryWeapon.Items.Add("2H Greatsword")
                        ddlSlayParryWeapon.Items.Add("2H Polearm")
                        ddlSlayParryWeapon.Items.Add("2H Axe")
                        ddlSlayParryWeapon.Items.Add("Bolt")
                        ddlSlayParryWeapon.Items.Add("2H Club")
                        ddlSlayParryWeapon.Items.Add("2H Mace")

                    Case Else
                End Select
            End If

        End If
    End Sub

    Public Sub BuildSlayParryMasterList()
        If ddlSlayParryMasterWeapon.SelectedIndex = -1 Then
            If ddlSpecGroup.SelectedIndex <> -1 Then
                ddlSlayParryMasterWeapon.Items.Clear()
                ddlSlayParryMasterWeapon.Items.Add(ddlSpecGroup.SelectedItem)
            End If
        End If
    End Sub

    Public Sub BuildCritList()
        If ddlCritSpecificWeapon.SelectedIndex = -1 Then
            ddlCritSpecificWeapon.Items.Clear()
            If skillSimpleProf.Value > 0 Then
                ddlCritSpecificWeapon.Items.Add("Dagger/Knife")
                ddlCritSpecificWeapon.Items.Add("Staff")
                ddlCritSpecificWeapon.Items.Add("Club")
                ddlCritSpecificWeapon.Items.Add("Thrown")
                ddlCritSpecificWeapon.Items.Add("Hand-to-Hand")

            End If
            If skillMedProf.Value > 0 Then
                ddlCritSpecificWeapon.Items.Add("Sword")
                ddlCritSpecificWeapon.Items.Add("Scimitar")
                ddlCritSpecificWeapon.Items.Add("Mace")
                ddlCritSpecificWeapon.Items.Add("Hammer")
                ddlCritSpecificWeapon.Items.Add("1H Spear")
                ddlCritSpecificWeapon.Items.Add("1H Axe")
                ddlCritSpecificWeapon.Items.Add("Javelin")
                ddlCritSpecificWeapon.Items.Add("Arrow")
                ddlCritSpecificWeapon.Items.Add("Claw")

            End If
            If skillLargeProf.Value > 0 Then
                ddlCritSpecificWeapon.Items.Add("2H Greatsword")
                ddlCritSpecificWeapon.Items.Add("2H Polearm")
                ddlCritSpecificWeapon.Items.Add("2H Axe")
                ddlCritSpecificWeapon.Items.Add("Bolt")
                ddlCritSpecificWeapon.Items.Add("2H Club")
                ddlCritSpecificWeapon.Items.Add("2H Mace")
            End If

            If skillExoticProf.Value > 0 AndAlso ddlExoticWeapon.SelectedIndex <> -1 Then
                ddlCritSpecificWeapon.Items.Add(ddlExoticWeapon.SelectedItem)
            End If
        End If
    End Sub

    Public Sub BuildCritMasterList()
        If ddlCritGroup.SelectedIndex = -1 Then
            ddlCritGroup.Items.Clear()
            If skillSimpleProf.Value > 0 Then
                ddlCritGroup.Items.Add("Simple")
            End If
            If skillMedProf.Value > 0 Then
                ddlCritGroup.Items.Add("Medium")
            End If
            If skillLargeProf.Value > 0 Then
                ddlCritGroup.Items.Add("Large")
            End If
        End If
    End Sub
    Public Sub BuildExecuteList()
        If ddlExecute.SelectedIndex = -1 Then
            If ddlCritSpecificWeapon.SelectedIndex <> -1 AndAlso ddlCritGroup.SelectedIndex <> -1 Then
                ddlExecute.Items.Clear()
                ddlExecute.Items.Add(ddlCritSpecificWeapon.SelectedItem)
                Select Case ddlCritGroup.SelectedItem
                    Case "Simple"
                        ddlExecute.Items.Add("Dagger/Knife")
                        ddlExecute.Items.Add("Staff")
                        ddlExecute.Items.Add("Club")
                        ddlExecute.Items.Add("Thrown")
                        ddlExecute.Items.Add("Hand-to-Hand")
                    Case "Medium"
                        ddlExecute.Items.Add("Sword")
                        ddlExecute.Items.Add("Scimitar")
                        ddlExecute.Items.Add("Mace")
                        ddlExecute.Items.Add("Hammer")
                        ddlExecute.Items.Add("1H Spear")
                        ddlExecute.Items.Add("1H Axe")
                        ddlExecute.Items.Add("Javelin")
                        ddlExecute.Items.Add("Arrow")
                        ddlExecute.Items.Add("Claw")

                    Case "Large"
                        ddlExecute.Items.Add("2H Greatsword")
                        ddlExecute.Items.Add("2H Polearm")
                        ddlExecute.Items.Add("2H Axe")
                        ddlExecute.Items.Add("Bolt")
                        ddlExecute.Items.Add("2H Club")
                        ddlExecute.Items.Add("2H Mace")

                    Case Else
                End Select

            ElseIf ddlCritSpecificWeapon.SelectedIndex <> -1 AndAlso ddlCritGroup.SelectedIndex = -1 Then
                ddlExecute.Items.Clear()
                ddlExecute.Items.Add(ddlCritSpecificWeapon.SelectedItem)
            ElseIf ddlCritSpecificWeapon.SelectedIndex = -1 AndAlso ddlCritGroup.SelectedIndex <> -1 Then
                ddlExecute.Items.Clear()
                Select Case ddlCritGroup.SelectedItem
                    Case "Simple"
                        ddlExecute.Items.Add("Dagger/Knife")
                        ddlExecute.Items.Add("Staff")
                        ddlExecute.Items.Add("Club")
                        ddlExecute.Items.Add("Thrown")
                        ddlExecute.Items.Add("Hand-to-Hand")
                    Case "Medium"
                        ddlExecute.Items.Add("Sword")
                        ddlExecute.Items.Add("Scimitar")
                        ddlExecute.Items.Add("Mace")
                        ddlExecute.Items.Add("Hammer")
                        ddlExecute.Items.Add("1H Spear")
                        ddlExecute.Items.Add("1H Axe")
                        ddlExecute.Items.Add("Javelin")
                        ddlExecute.Items.Add("Arrow")
                        ddlExecute.Items.Add("Claw")

                    Case "Large"
                        ddlExecute.Items.Add("2H Greatsword")
                        ddlExecute.Items.Add("2H Polearm")
                        ddlExecute.Items.Add("2H Axe")
                        ddlExecute.Items.Add("Bolt")
                        ddlExecute.Items.Add("2H Club")
                        ddlExecute.Items.Add("2H Mace")

                    Case Else
                End Select
            End If

        End If
    End Sub
    Sub BuildExecuteMasterList()
        If ddlExecuteMaster.SelectedIndex = -1 Then
            ddlExecuteMaster.Items.Clear()
            If ddlCritGroup.SelectedIndex <> -1 Then ddlExecuteMaster.Items.Add(ddlCritGroup.SelectedItem)
        End If
    End Sub
#End Region

#Region "Spell Slots"

    Private Sub countC1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpell1.ValueChanged
        Slot1()
    End Sub
    Private Sub Slot1()
        Select Case skillSpell1.Value
            Case 0
                skillSpell2.Maximum = 0
            Case 1
                skillSpell2.Maximum = 0
            Case 2
                skillSpell2.Maximum = 1
            Case 3
                skillSpell2.Maximum = 2
            Case 4
                skillSpell2.Maximum = 3
            Case 5
                skillSpell2.Maximum = 5
            Case 6 To 10
                skillSpell2.Maximum = skillSpell1.Value
        End Select
        Recalc()
    End Sub

    Private Sub CountC2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpell2.ValueChanged
        Slot2()
    End Sub
    Private Sub Slot2()
        Select Case skillSpell2.Value
            Case 0
                skillSpell3.Maximum = 0
            Case 1
                skillSpell3.Maximum = 0
            Case 2
                skillSpell3.Maximum = 1
            Case 3
                skillSpell3.Maximum = 2
            Case 4
                skillSpell3.Maximum = 3
            Case 5
                skillSpell3.Maximum = 5
            Case 6 To 10
                skillSpell3.Maximum = skillSpell2.Value
        End Select
        Recalc()
    End Sub
    Private Sub CountC3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpell3.ValueChanged
        SLot3()
    End Sub
    Private Sub SLot3()
        Select Case skillSpell3.Value
            Case 0
                skillSpell4.Maximum = 0
            Case 1
                skillSpell4.Maximum = 0
            Case 2
                skillSpell4.Maximum = 1
            Case 3
                skillSpell4.Maximum = 2
            Case 4
                skillSpell4.Maximum = 3
            Case 5
                skillSpell4.Maximum = 5
            Case 6 To 10
                skillSpell4.Maximum = skillSpell3.Value
        End Select
        Recalc()
    End Sub

    Private Sub CountC4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpell4.ValueChanged
        Slot4()
    End Sub
    Private Sub Slot4()
        Select Case skillSpell4.Value
            Case 0
                skillSpell5.Maximum = 0
            Case 1
                skillSpell5.Maximum = 0
            Case 2
                skillSpell5.Maximum = 1
            Case 3
                skillSpell5.Maximum = 2
            Case 4
                skillSpell5.Maximum = 3
            Case 5
                skillSpell5.Maximum = 5
            Case 6 To 10
                skillSpell5.Maximum = skillSpell4.Value
        End Select
        Recalc()
    End Sub

    Private Sub CountC5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpell5.ValueChanged
        SLot5()
    End Sub
    Private Sub SLot5()
        Select Case skillSpell5.Value
            Case 0
                skillSpell6.Maximum = 0
            Case 1
                skillSpell6.Maximum = 0
            Case 2
                skillSpell6.Maximum = 1
            Case 3
                skillSpell6.Maximum = 2
            Case 4
                skillSpell6.Maximum = 3
            Case 5
                skillSpell6.Maximum = 5
            Case 6 To 10
                skillSpell6.Maximum = skillSpell5.Value
        End Select
        Recalc()
    End Sub
    Private Sub CountC6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpell6.ValueChanged
        Slot6()
    End Sub
    Private Sub Slot6()
        Select Case skillSpell6.Value
            Case 0
                skillSpell7.Maximum = 0
            Case 1
                skillSpell7.Maximum = 0
            Case 2
                skillSpell7.Maximum = 1
            Case 3
                skillSpell7.Maximum = 2
            Case 4
                skillSpell7.Maximum = 3
            Case 5
                skillSpell7.Maximum = 5
            Case 6 To 10
                skillSpell7.Maximum = skillSpell6.Value
        End Select
        Recalc()
    End Sub
    Private Sub CountC7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpell7.ValueChanged
        Slot7()
    End Sub
    Private Sub Slot7()
        Select Case skillSpell7.Value
            Case 0
                skillSpell8.Maximum = 0
            Case 1
                skillSpell8.Maximum = 0
            Case 2
                skillSpell8.Maximum = 1
            Case 3
                skillSpell8.Maximum = 2
            Case 4
                skillSpell8.Maximum = 3
            Case 5
                skillSpell8.Maximum = 5
            Case 6 To 10
                skillSpell8.Maximum = skillSpell7.Value
        End Select
        Recalc()
    End Sub

    Private Sub CountC8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpell8.ValueChanged
        Slot8()
    End Sub
    Private Sub Slot8()
        Select Case skillSpell8.Value
            Case 0
                skillSpell9.Maximum = 0
            Case 1
                skillSpell9.Maximum = 0
            Case 2
                skillSpell9.Maximum = 1
            Case 3
                skillSpell9.Maximum = 2
            Case 4
                skillSpell9.Maximum = 3
            Case 5
                skillSpell9.Maximum = 5
            Case 6 To 10
                skillSpell9.Maximum = skillSpell8.Value
        End Select
        Recalc()
    End Sub

    Private Sub CountC9_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpell9.ValueChanged
        SLot9()
    End Sub
    Private Sub SLot9()
        Select Case skillSpell9.Value
            Case 0
                skillSpellRitual.Maximum = 0
            Case 1 To 4
                skillSpellRitual.Maximum = 10
            Case 5 To 10
                skillSpellRitual.Maximum = 10
                skillSpell1.Maximum = 10
        End Select
        Recalc()
    End Sub

#End Region
    Private Sub ComboRace_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlCharRace.SelectedIndexChanged

        skillRacial2.Value = 0
        skillBPB.Value = 0
        skillStr.Value = 0
        RaceCP = 0
        ddlFragGuild.Visible = False
        ddlFragGuild.SelectedIndex = -1
        ddlFragCharRace.Visible = False
        'ddlFragRace.Visible = False
        ddlFragCharRace.SelectedIndex = -1
        'ddlFragRace.SelectedIndex = -1
        Select Case ddlCharRace.SelectedIndex
            Case 0 To 11
                Race = 800 + ddlCharRace.SelectedIndex
            Case 12
                ddlFragCharRace.Visible = True

        End Select
        If Race = 806 Then RaceCP = 50
        listRacial.Items.Clear()
        If Race = 809 Then
            listRacial.Items.Add("Yes")
            listRacial.Items.Add("No")
        ElseIf Race = 810 Then
            listRacial.Items.Add("Angels/Demons")
            listRacial.Items.Add("Animals")
            listRacial.Items.Add("Bestial")
            listRacial.Items.Add("Brood")
            listRacial.Items.Add("Constructs")
            listRacial.Items.Add("Draconic")
            listRacial.Items.Add("Dwarves")
            listRacial.Items.Add("Elementals")
            listRacial.Items.Add("Elves")
            listRacial.Items.Add("Fae")
            listRacial.Items.Add("Goblinoids")
            listRacial.Items.Add("Humanoids")
            listRacial.Items.Add("Plants")
            listRacial.Items.Add("Spirits")
            listRacial.Items.Add("Undead")
            listRacial.Items.Add("Vermin")
        End If
        TotalCP = BlanketCP + RaceCP + InitialCP
        boxTotalCP.Text = TotalCP
        RaceName = ddlCharRace.SelectedItem
        Recalc()
    End Sub

    Private Sub CountBlankets_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numericBlanketAmt.ValueChanged
        Select Case numericBlanketAmt.Value
            Case 0
                BlanketCP = 150
            Case 1
                BlanketCP = 215
            Case 2
                BlanketCP = 280
            Case 3
                BlanketCP = 323
            Case 4
                BlanketCP = 366
            Case 5
                BlanketCP = 400
            Case 6
                BlanketCP = 434
            Case 7
                BlanketCP = 468
            Case 8
                BlanketCP = 496
            Case 9
                BlanketCP = 524
            Case 10
                BlanketCP = 552
            Case 11
                BlanketCP = 576
            Case 12
                BlanketCP = 600
            Case 13
                BlanketCP = 624
            Case 14
                BlanketCP = 648
            Case 15
                BlanketCP = 672
            Case 16
                BlanketCP = 694
            Case 17
                BlanketCP = 716
            Case 18
                BlanketCP = 738
            Case 19
                BlanketCP = 760
            Case 20
                BlanketCP = 779
            Case 21
                BlanketCP = 798
            Case 22
                BlanketCP = 817
            Case 23
                BlanketCP = 836
            Case 24
                BlanketCP = 855
            Case 25
                BlanketCP = 872
            Case 26
                BlanketCP = 889
            Case 27
                BlanketCP = 906
            Case 28
                BlanketCP = 923
            Case 29
                BlanketCP = 940
            Case 30
                BlanketCP = 957
            Case 31
                BlanketCP = 973
            Case 32
                BlanketCP = 989
            Case 33
                BlanketCP = 1005
            Case 34
                BlanketCP = 1021
            Case 35
                BlanketCP = 1037
            Case 36
                BlanketCP = 1053
            Case 37
                BlanketCP = 1068
            Case 38
                BlanketCP = 1083
            Case 39
                BlanketCP = 1098
            Case 40
                BlanketCP = 1113
            Case 41
                BlanketCP = 1128
            Case 42
                BlanketCP = 1143
            Case 43
                BlanketCP = 1158
            Case 44
                BlanketCP = 1172
            Case 45
                BlanketCP = 1186
            Case 46
                BlanketCP = 1200
            Case 47
                BlanketCP = 1214
            Case 48
                BlanketCP = 1228
            Case 49
                BlanketCP = 1242
            Case 50
                BlanketCP = 1256
            Case 51
                BlanketCP = 1269
            Case 52
                BlanketCP = 1282
            Case 53
                BlanketCP = 1295
            Case 54
                BlanketCP = 1308
            Case 55
                BlanketCP = 1321
            Case 56
                BlanketCP = 1334
            Case 57
                BlanketCP = 1347
            Case 58
                BlanketCP = 1360
            Case 59
                BlanketCP = 1372
            Case 60
                BlanketCP = 1384
            Case 61
                BlanketCP = 1396
            Case 62
                BlanketCP = 1408
            Case 63
                BlanketCP = 1420
            Case 64
                BlanketCP = 1432
            Case 65
                BlanketCP = 1444
            Case 66
                BlanketCP = 1456
            Case 67
                BlanketCP = 1468
            Case 68
                BlanketCP = 1480
            Case 69
                BlanketCP = 1492
            Case 70
                BlanketCP = 1504
            Case 71
                BlanketCP = 1516
            Case 72
                BlanketCP = 1528
            Case 73
                BlanketCP = 1540
            Case 74
                BlanketCP = 1552
            Case 75
                BlanketCP = 1563
            Case 76
                BlanketCP = 1574
            Case 77
                BlanketCP = 1585
            Case 78
                BlanketCP = 1596
            Case 79
                BlanketCP = 1607
            Case 80
                BlanketCP = 1618
            Case 81
                BlanketCP = 1629
            Case 82
                BlanketCP = 1640
            Case 83
                BlanketCP = 1651
            Case 84
                BlanketCP = 1662
            Case 85
                BlanketCP = 1673
            Case 86
                BlanketCP = 1684
            Case 87
                BlanketCP = 1695
            Case 88
                BlanketCP = 1706
            Case 89
                BlanketCP = 1717
            Case 90
                BlanketCP = 1728
            Case 91
                BlanketCP = 1739
            Case 92
                BlanketCP = 1750
            Case 93
                BlanketCP = 1760
            Case 94 To 9999
                BlanketCP = 1760 + 10 * (numericBlanketAmt.Value - 93)
        End Select
        Level = Int((BlanketCP - 50) / 100)
        boxLevel.Text = Level
        BlanketCP = BlanketCP - 150
        TotalCP = BlanketCP + RaceCP + InitialCP
        Recalc()
    End Sub

#Region "General Handlers"
    Private Sub ddlCharJob_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlCharJob.SelectedIndexChanged
        skillFrag1.Value = 0
        skillFrag2.Value = 0
        skillFrag3.Value = 0
        skillJob1.Value = 0
        skillJob2.Value = 0
        skillJob3.Value = 0
        skillJob4.Value = 0
        chkVocation.Checked = False
        ddlVocation.SelectedIndex = -1

        Select Case ddlCharJob.SelectedIndex
            Case -1
                chkVocation.Checked = False
                chkVocation.Visible = False
            Case 0 To 13
                Job = ddlCharJob.SelectedIndex + 1000
                JobName = ddlCharJob.SelectedItem
                chkVocation.Visible = True
        End Select
        Recalc()
    End Sub

    Private Sub SkillAlchemy_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillAlchemy.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillBlacksmith_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillBlacksmith.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillCreateScroll_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillCreateScroll.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillTrapsmith_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillTrapsmith.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillJob1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillJob1.ValueChanged
        Job = ddlCharJob.SelectedIndex + 1000
        Recalc()

        Select Case ddlVocation.SelectedItem
            Case "Archer"
                Job = 1100
            Case "Battle Mage"
                Job = 1101
            Case "Brew Master"
                Job = 1102
            Case "Stalwart"
                Job = 1103
            Case "Undead Hunter"
                Job = 1104
            Case "Shaman"
                Job = 1105
            Case "Artisan"
                Job = 1106
            Case "Swashbuckler"
                Job = 1107
        End Select
        JobName = ddlVocation.SelectedItem
        SetJobSkills()
    End Sub

    Private Sub SkillJob2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillJob2.ValueChanged
        Job = ddlCharJob.SelectedIndex + 1000
        Recalc()

        Select Case ddlVocation.SelectedItem
            Case "Archer"
                Job = 1100
            Case "Battle Mage"
                Job = 1101
            Case "Brew Master"
                Job = 1102
            Case "Stalwart"
                Job = 1103
            Case "Undead Hunter"
                Job = 1104
            Case "Shaman"
                Job = 1105
            Case "Artisan"
                Job = 1106
            Case "Swashbuckler"
                Job = 1107
        End Select
        JobName = ddlVocation.SelectedItem
        SetJobSkills()
    End Sub

    Private Sub SkillJob3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillJob3.ValueChanged
        Job = ddlCharJob.SelectedIndex + 1000
        Recalc()

        Select Case ddlVocation.SelectedItem
            Case "Archer"
                Job = 1100
            Case "Battle Mage"
                Job = 1101
            Case "Brew Master"
                Job = 1102
            Case "Stalwart"
                Job = 1103
            Case "Undead Hunter"
                Job = 1104
            Case "Shaman"
                Job = 1105
            Case "Artisan"
                Job = 1106
            Case "Swashbuckler"
                Job = 1107
        End Select
        JobName = ddlVocation.SelectedItem
        SetJobSkills()
    End Sub

    Private Sub SkillJob4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillJob4.ValueChanged
        Job = ddlCharJob.SelectedIndex + 1000
        Recalc()

        Select Case ddlVocation.SelectedItem
            Case "Archer"
                Job = 1100
            Case "Battle Mage"
                Job = 1101
            Case "Brew Master"
                Job = 1102
            Case "Stalwart"
                Job = 1103
            Case "Undead Hunter"
                Job = 1104
            Case "Shaman"
                Job = 1105
            Case "Artisan"
                Job = 1106
            Case "Swashbuckler"
                Job = 1107
        End Select
        JobName = ddlVocation.SelectedItem
        SetJobSkills()
    End Sub

    Private Sub DDLFragCharRace_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlFragCharRace.SelectedIndexChanged
        skillRacial2.Value = 0
        skillBPB.Value = 0
        skillStr.Value = 0
        Select Case ddlFragCharRace.SelectedIndex
            Case 0
                Race = 812
            Case 1
                Race = 813
            Case 2
                Race = 814
            Case 3
                Race = 815
            Case 4
                Race = 816
            Case 5
                Race = 817
            Case 6
                Race = 818
            Case 7
                Race = 819
            Case 8
                Race = 820
            Case 9
                Race = 821
                skillRacialAuto.Value = 1
            Case 10
                Race = 822
            Case 11
                Race = 823
            Case 12
                Race = 824
            Case 13
                Race = 825
            Case 14
                Race = 826
            Case 15
                Race = 827
            Case 16
                Race = 828
            Case 17
                Race = 829
            Case 18
                Race = 830
            Case 19
                Race = 831
            Case 20
                Race = 832
        End Select
        RaceName = ddlFragCharRace.SelectedItem

        Recalc()
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        skillAlchemy.Value = 0
        skillBlacksmith.Value = 0
        skillCraft1.Value = 0
        skillCreateScroll.Value = 0
        skillTrapsmith.Value = 0

        skillFrag1.Value = 0
        skillFrag2.Value = 0
        skillFrag3.Value = 0
        skillFrag4.Value = 0
        skillFrag5.Value = 0
        skillFrag6.Value = 0

        skillLooting.Value = 0
        skillPossum.Value = 0
        skillParagon.Value = 0
        skillTeacher.Value = 0
        skillCreateAlcohol.Value = 0
        skillHeavyDrinker.Value = 0

        skillSpell1.Value = 0
        skillSpell2.Value = 0
        skillSpell3.Value = 0
        skillSpell4.Value = 0
        skillSpell5.Value = 0
        skillSpell6.Value = 0
        skillSpell7.Value = 0
        skillSpell8.Value = 0
        skillSpell9.Value = 0
        skillSpellRitual.Value = 0
        skillSpellVersa1.Value = 0
        skillSpellVersa2.Value = 0
        skillSpellVersa3.Value = 0
        skillSpellVersa4.Value = 0
        skillSpellVersa5.Value = 0
        skillSpellVersa6.Value = 0
        skillSpellVersa7.Value = 0
        skillSpellVersa8.Value = 0
        skillSpellVersa9.Value = 0

        ddlPyramid.SelectedIndex = 0

        skillAnatomy.Value = 0
        skillMysticism.Value = 0
        skillDemonAngelArts.Value = 0
        skillEleAttunement.Value = 0
        skillFirstAid.Value = 0
        skillNecroArts.Value = 0
        skillPhysician.Value = 0
        skillReadAndWrite.Value = 0
        skillReadMagic.Value = 0
        skillReadMagicAvd.Value = 0
        skillReadMagicRitual.Value = 0
        skillSpell1.Value = 0
        skillSpell2.Value = 0
        skillSpell3.Value = 0
        skillSpell4.Value = 0
        skillSpell5.Value = 0
        skillSpell6.Value = 0
        skillSpell7.Value = 0
        skillSpell8.Value = 0
        skillSpell9.Value = 0
        skillSpellRitual.Value = 0
        skillSphere1.Value = 0
        skillSphere2.Value = 0
        skillSphere3.Value = 0
        skillAdvRitual.Value = 0

        skillAmbidexterity.Value = 0
        skillFlorentine.Value = 0
        skillFlurryOfBlows.Value = 0
        skillHeavyArmour.Value = 0
        skillSelfMut.Value = 0
        skillShield.Value = 0
        skillSlayParry.Value = 0
        skillSlayParryMaster.Value = 0
        skillSpecGroup.Value = 0
        skillSpecSpecific.Value = 0
        skillMedProf.Value = 0
        skillLargeProf.Value = 0
        skillExoticProf.Value = 0
        skillWeaponRefocus.Value = 0

        skillCritSpecific.Value = 0
        skillCritGroup.Value = 0
        skillDodge.Value = 0
        skillExecute.Value = 0
        skillExecuteMaster.Value = 0
        skillGarrote.Value = 0
        skillSap.Value = 0
        skillVitalBlow.Value = 0

        skillJob1.Value = 0
        skillJob2.Value = 0
        skillJob3.Value = 0
        skillJob4.Value = 0

        skillRacial2.Value = 0
        skillBPB.Value = 0
        skillStr.Value = 0
        listRacial.Visible = False
        lblRacialAuto.Visible = False
        skillRacialAuto.Visible = False
        skillRacialAuto.Value = 1
        costRacialAuto.Visible = False
        lblRacial2.Text = "Racial Skill"

        Race = 0
        JobHP = 0
        BOnusHP = 0
        boxPlayerName.Text = ""
        boxCharName.Text = ""
        boxTotalCP.Text = ""
        boxSpentCP.Text = ""
        boxFreeCP.Text = ""
        boxLevel.Text = ""
        boxHP.Text = ""
        boxSkillBreakdown.Text = ""
        ddlCharRace.SelectedIndex = -1
        ddlCharJob.SelectedIndex = -1
        ddlVocation.SelectedIndex = -1
        numericBlanketAmt.Value = 0
        chkVocation.Checked = False

        Recalc()
    End Sub

    Private Sub DataStore()
        PlayerName = boxPlayerName.Text
        CharacterName = boxCharName.Text
    End Sub

    Private Sub BtnSaveAsText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAsText.Click
        DataStore()
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Text File|*.txt"
        saveFileDialog1.Title = "Save a Text File"
        Dim filename As String
        filename = boxCharName.Text
        saveFileDialog1.FileName = filename
        saveFileDialog1.ShowDialog()

        ' If the file name is not an empty string open it for saving.
        If saveFileDialog1.FileName <> "" Then
            My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName,
"Player: " & PlayerName & vbNewLine & "Character: " & CharacterName & vbNewLine & "Race: " & RaceName & vbNewLine & "Occupation: " & JobName & vbNewLine & "Level: " & Level & vbNewLine & "Hit Points: " & HPTotal() & vbNewLine & "Blankets Applied: " & numericBlanketAmt.Value & vbNewLine & "Total CP: " & TotalCP & vbNewLine & "Spent CP: " & SpentCP & vbNewLine & "Free CP: " & FreeCP & vbNewLine & "Skills: " & vbNewLine & boxSkillBreakdown.Text, False)
        End If
    End Sub

    Private Sub BtnSaveToFile_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveToFile.Click
        Dim B64a As String
        Dim B64b As String
        B64a = ""
        B64b = ""
        If Race = 0 Then
            MsgBox("Please Select a Race before saving")
        Else
            DataStore()
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "UW Character|*.uwc"
            saveFileDialog1.Title = "Save an Underworld Character File"
            Dim filename As String
            filename = boxCharName.Text
            saveFileDialog1.FileName = filename
            saveFileDialog1.ShowDialog()

            ' If the file name is not an empty string open it for saving.
            If saveFileDialog1.FileName <> "" Then
                B64b = PlayerName & "," & CharacterName & "," & Race & "," & Job & "," & numericBlanketAmt.Value & "," & skillAlchemy.Value & "," _
                & skillBlacksmith.Value & "," & skillCraft1.Value & "," & skillCreateScroll.Value & "," & skillTrapsmith.Value & "," & skillAnatomy.Value & "," _
                & skillMysticism.Value & "," & skillDemonAngelArts.Value & "," & skillEleAttunement.Value & "," & skillFirstAid.Value & "," & skillNecroArts.Value & "," _
                & skillPhysician.Value & "," & skillReadAndWrite.Value & "," & skillReadMagic.Value & "," & skillReadMagicAvd.Value & "," & skillReadMagicRitual.Value & "," _
                & skillSpell1.Value & "," & skillSpell2.Value & "," & skillSpell3.Value & "," & skillSpell4.Value & "," & skillSpell5.Value & "," & skillSpell6.Value & "," _
                & skillSpell7.Value & "," & skillSpell8.Value & "," & skillSpell9.Value & "," & skillSpellRitual.Value & "," & skillSphere1.Value & ","
                B64b = B64b & skillSphere2.Value & "," & skillSphere3.Value & "," & skillAmbidexterity.Value & "," & skillFlorentine.Value & "," & skillFlurryOfBlows.Value & "," _
                & skillHeavyArmour.Value & "," & skillSelfMut.Value & "," & skillShield.Value & "," & skillSlayParry.Value & "," & skillSlayParryMaster.Value & "," _
                & skillSpecGroup.Value & "," & skillSpecSpecific.Value & "," & skillSimpleProf.Value & "," & skillMedProf.Value & "," & skillLargeProf.Value & "," _
                & skillExoticProf.Value & "," & skillWeaponRefocus.Value & "," & skillCritSpecific.Value & "," & skillCritGroup.Value & "," & skillDodge.Value & "," _
                & skillExecute.Value & "," & skillExecuteMaster.Value & "," & skillGarrote.Value & "," & skillSap.Value & "," & skillVitalBlow.Value & "," _
                & skillJob1.Value & "," & skillJob2.Value & "," & skillJob3.Value & "," & skillJob4.Value & "," & skillRacial2.Value & "," & skillBPB.Value & "," _
                & skillStr.Value & "," & ddlSphere1.SelectedItem & "," & ddlSphere2.SelectedItem & "," & ddlSphere3.SelectedItem & "," & ddlSpecGroup.SelectedIndex & "," _
                & ddlSpecSpecific.SelectedIndex & "," & ddlExoticWeapon.SelectedIndex & "," & ddlSlayParryWeapon.SelectedIndex & "," _
                & ddlSlayParryMasterWeapon.SelectedIndex & "," & ddlCritSpecificWeapon.SelectedIndex & "," & ddlCritGroup.SelectedIndex & "," & ddlExecute.SelectedIndex & "," _
                & skillRacialAuto.Value & "," & listRacial.SelectedIndex & "," & skillFrag1.Value & "," & skillFrag2.Value & "," & skillFrag3.Value & "," _
                & skillHeavyDrinker.Value & "," & skillLooting.Value & "," & skillTeacher.Value & "," & skillCreateAlcohol.Value & "," & skillPossum.Value & "," _
                & skillParagon.Value & "," & skillSpellVersa1.Value & "," & skillSpellVersa2.Value & "," & skillSpellVersa3.Value & "," & skillSpellVersa4.Value & "," _
                & skillSpellVersa5.Value & "," & skillSpellVersa6.Value & "," & skillSpellVersa7.Value & "," & skillSpellVersa8.Value & "," & skillSpellVersa9.Value & "," _
                & ddlEleAttunement1.SelectedIndex & "," & ddlEleAttunement2.SelectedIndex & "," & ddlEleAttunement3.SelectedIndex & "," & ddlEleAttunement4.SelectedIndex & "," _
                & boxCraft1.Text & "," & boxCraft2.Text & "," & boxCraft3.Text & "," & boxCraft4.Text & "," & skillAdvRitual.Value & "," & skillChemistry.Value & "," & skillArtifice.Value
                My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, B64b, False)
            End If
        End If

    End Sub

    Private Sub SkillFrag1_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillFrag1.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillFrag2_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillFrag2.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillFrag3_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillFrag3.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillFrag4_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillFrag4.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillFrag5_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillFrag5.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillFrag6_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillFrag6.ValueChanged
        Recalc()
    End Sub

    Private Sub Skill903_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillLooting.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillTeacher_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillTeacher.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillPossum_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillPossum.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillParagon_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillParagon.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillCreateAlcohol_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Recalc()
    End Sub

    Private Sub SkillHeavyDrinker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillHeavyDrinker.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillSpellVersa1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpellVersa1.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillSpellVersa2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpellVersa2.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillSpellVersa3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpellVersa3.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillSpellVersa4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpellVersa4.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillSpellVersa5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpellVersa5.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillSpellVersa6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpellVersa6.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillSpellVersa7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpellVersa7.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillSpellVersa8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpellVersa8.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillSpellVersa9_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpellVersa9.ValueChanged
        Recalc()
    End Sub


    Private Sub skillRacial2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillRacial2.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillBPB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillBPB.ValueChanged
        Recalc()
    End Sub

    Private Sub Skill602_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillStr.ValueChanged
        Recalc()
    End Sub

    Private Sub BoxTotalCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxTotalCP.TextChanged

    End Sub

    Private Sub BoxSpentCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSpentCP.TextChanged

    End Sub

    Private Sub BoxFreeCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxFreeCP.TextChanged

    End Sub

    Private Sub BoxHP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxHP.TextChanged

    End Sub

    Private Sub BoxLevel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxLevel.TextChanged

    End Sub

    Private Sub ListRacial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listRacial.SelectedIndexChanged
        Recalc()
    End Sub

    Private Sub SkillRacialAuto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillRacialAuto.ValueChanged
        Recalc()
    End Sub

    Private Sub BtnOpenFile_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        Dim OpenFileDialog1 As New OpenFileDialog()
        Dim B64a As Object = Nothing
        Dim B64b As Object = Nothing
        OpenFileDialog1.Filter = "UW Character|*.uwc"
        OpenFileDialog1.Title = "Open an Underworld Character File"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            OpenSave = True
            B64a = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            InBox.Items.Clear()
            Dim StoreArray() As String = Split(B64a, ",")
            For i = 0 To StoreArray.Length - 1
                InBox.Items.Add(StoreArray(i))
            Next i

            boxPlayerName.Text = InBox.Items(0)
            boxCharName.Text = InBox.Items(1)
            If InBox.Items(2) < 812 Then
                ddlCharRace.SelectedIndex = InBox.Items(2) - 800
            Else
                ddlCharRace.SelectedIndex = 12
                ddlFragCharRace.SelectedIndex = InBox.Items(2) - 812
            End If
            ddlCharJob.SelectedIndex = InBox.Items(3) - 1000
            numericBlanketAmt.Value = InBox.Items(4)
            skillAlchemy.Value = InBox.Items(5)
            skillBlacksmith.Value = InBox.Items(6)
            skillCraft1.Value = InBox.Items(7)
            skillCreateScroll.Value = InBox.Items(8)
            skillTrapsmith.Value = InBox.Items(9)
            skillAnatomy.Value = InBox.Items(10)
            skillMysticism.Value = InBox.Items(11)
            skillDemonAngelArts.Value = InBox.Items(12)
            skillEleAttunement.Value = InBox.Items(13)
            skillFirstAid.Value = InBox.Items(14)
            skillNecroArts.Value = InBox.Items(15)
            skillPhysician.Value = InBox.Items(16)
            skillReadAndWrite.Value = InBox.Items(17)
            skillReadMagic.Value = InBox.Items(18)
            skillReadMagicAvd.Value = InBox.Items(19)
            skillReadMagicRitual.Value = InBox.Items(20)
            skillSpell1.Maximum = 10
            skillSpell2.Maximum = 10
            skillSpell3.Maximum = 10
            skillSpell4.Maximum = 10
            skillSpell5.Maximum = 10
            skillSpell6.Maximum = 10
            skillSpell7.Maximum = 10
            skillSpell8.Maximum = 10
            skillSpell9.Maximum = 10
            skillSpell9.Value = InBox.Items(29)
            skillSpell8.Value = InBox.Items(28)
            skillSpell7.Value = InBox.Items(27)
            skillSpell6.Value = InBox.Items(26)
            skillSpell5.Value = InBox.Items(25)
            skillSpell4.Value = InBox.Items(24)
            skillSpell3.Value = InBox.Items(23)
            skillSpell2.Value = InBox.Items(22)
            skillSpell1.Value = InBox.Items(21)
            skillSpellRitual.Value = InBox.Items(30)
            skillSphere1.Value = InBox.Items(31)
            skillSphere2.Value = InBox.Items(32)
            skillSphere3.Value = InBox.Items(33)
            skillAmbidexterity.Value = InBox.Items(34)
            skillFlorentine.Value = InBox.Items(35)
            skillFlurryOfBlows.Value = InBox.Items(36)
            skillHeavyArmour.Value = InBox.Items(37)
            skillSelfMut.Value = InBox.Items(38)
            skillShield.Value = InBox.Items(39)
            skillSlayParry.Value = InBox.Items(40)
            skillSlayParryMaster.Value = InBox.Items(41)
            skillSpecGroup.Value = InBox.Items(42)
            skillSpecSpecific.Value = InBox.Items(43)
            skillSimpleProf.Value = InBox.Items(44)
            skillMedProf.Value = InBox.Items(45)
            skillLargeProf.Value = InBox.Items(46)
            skillExoticProf.Value = InBox.Items(47)
            skillWeaponRefocus.Value = InBox.Items(48)
            skillCritSpecific.Value = InBox.Items(49)
            skillCritGroup.Value = InBox.Items(50)
            skillDodge.Value = InBox.Items(51)
            skillExecute.Value = InBox.Items(52)
            skillExecuteMaster.Value = InBox.Items(53)
            skillGarrote.Value = InBox.Items(54)
            skillSap.Value = InBox.Items(55)
            skillVitalBlow.Value = InBox.Items(56)
            skillJob1.Value = InBox.Items(57)
            skillJob2.Value = InBox.Items(58)
            skillJob3.Value = InBox.Items(59)
            skillJob4.Value = InBox.Items(60)
            skillRacial2.Value = InBox.Items(61)
            skillBPB.Value = InBox.Items(62)
            skillStr.Value = InBox.Items(63)
            ddlSphere1.SelectedItem = InBox.Items(64)
            ddlSphere2.SelectedItem = InBox.Items(65)
            ddlSphere3.SelectedItem = InBox.Items(66)
            ddlSpecGroup.SelectedIndex = InBox.Items(67)
            ddlSpecSpecific.SelectedIndex = InBox.Items(68)
            ddlExoticWeapon.SelectedIndex = InBox.Items(69)
            ddlSlayParryWeapon.SelectedIndex = InBox.Items(70)
            ddlSlayParryMasterWeapon.SelectedIndex = InBox.Items(71)
            ddlCritSpecificWeapon.SelectedIndex = InBox.Items(72)
            ddlCritGroup.SelectedIndex = InBox.Items(73)
            ddlExecute.SelectedIndex = InBox.Items(74)
            skillRacialAuto.Value = InBox.Items(75)
            listRacial.SelectedIndex = InBox.Items(76)
            skillFrag1.Value = InBox.Items(77)
            skillFrag2.Value = InBox.Items(78)
            skillFrag3.Value = InBox.Items(79)
            skillHeavyDrinker.Value = InBox.Items(80)
            skillLooting.Value = InBox.Items(81)
            skillTeacher.Value = InBox.Items(82)
            skillCreateAlcohol.Value = InBox.Items(83)
            skillPossum.Value = InBox.Items(84)
            skillParagon.Value = InBox.Items(85)
            skillSpellVersa1.Value = InBox.Items(86)
            skillSpellVersa2.Value = InBox.Items(87)
            skillSpellVersa3.Value = InBox.Items(88)
            skillSpellVersa4.Value = InBox.Items(89)
            skillSpellVersa5.Value = InBox.Items(90)
            skillSpellVersa6.Value = InBox.Items(91)
            skillSpellVersa7.Value = InBox.Items(92)
            skillSpellVersa8.Value = InBox.Items(93)
            skillSpellVersa9.Value = InBox.Items(94)
            ddlEleAttunement1.SelectedIndex = InBox.Items(95)
            ddlEleAttunement2.SelectedIndex = InBox.Items(96)
            ddlEleAttunement3.SelectedIndex = InBox.Items(97)
            ddlEleAttunement4.SelectedIndex = InBox.Items(98)
            boxCraft1.Text = InBox.Items(99)
            boxCraft2.Text = InBox.Items(100)
            boxCraft3.Text = InBox.Items(101)
            boxCraft4.Text = InBox.Items(102)
            skillAdvRitual.Value = InBox.Items(103)
            skillChemistry.Value = InBox.Items(104)
            skillArtifice.Value = InBox.Items(105)

            OpenSave = False
        End If
    End Sub
    Private Sub SkillCraft1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillCraft1.ValueChanged
        If skillCraft1.Value = 1 Then
            boxCraft1.Enabled = True
            boxCraft2.Enabled = False
            boxCraft3.Enabled = False
            boxCraft4.Enabled = False
        ElseIf skillCraft1.Value = 2 Then
            boxCraft1.Enabled = True
            boxCraft2.Enabled = True
            boxCraft3.Enabled = False
            boxCraft4.Enabled = False
        ElseIf skillCraft1.Value = 3 Then
            boxCraft1.Enabled = True
            boxCraft2.Enabled = True
            boxCraft3.Enabled = True
            boxCraft4.Enabled = False
        ElseIf skillCraft1.Value > 3 Then
            boxCraft1.Enabled = True
            boxCraft2.Enabled = True
            boxCraft3.Enabled = True
            boxCraft4.Enabled = True
        Else
            boxCraft1.Enabled = False
            boxCraft1.Text = ""
            boxCraft2.Enabled = False
            boxCraft2.Text = ""
            boxCraft3.Enabled = False
            boxCraft3.Text = ""
            boxCraft4.Enabled = False
            boxCraft4.Text = ""
        End If
        Recalc()
    End Sub

    Private Sub BoxCraft1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxCraft1.TextChanged
        Recalc()
    End Sub

    Private Sub BoxCraft2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxCraft2.TextChanged
        Recalc()
    End Sub

    Private Sub boxCraft3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxCraft3.TextChanged
        Recalc()
    End Sub

    Private Sub BoxCraft4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxCraft4.TextChanged
        Recalc()
    End Sub

    Private Sub CostTrapsmith_Click(sender As Object, e As EventArgs) Handles costTrapsmith.Click
        Recalc()
    End Sub

    Private Sub CostBPB_Click(sender As Object, e As EventArgs) Handles costBPB.Click
        Recalc()
    End Sub

    Private Sub DDLVocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlVocation.SelectedIndexChanged
        Job = ddlCharJob.SelectedIndex + 1000
        Recalc()

        Select Case ddlVocation.SelectedItem
            Case "Archer"
                Job = 1100
            Case "Battle Mage"
                Job = 1101
            Case "Brew Master"
                Job = 1102
            Case "Stalwart"
                Job = 1103
            Case "Undead Hunter"
                Job = 1104
            Case "Shaman"
                Job = 1105
            Case "Artisan"
                Job = 1106
            Case "Swashbuckler"
                Job = 1107
        End Select
        JobName = ddlVocation.SelectedItem
        SetJobSkills()
    End Sub

    Private Sub ChkVocation_CheckedChanged(sender As Object, e As EventArgs) Handles chkVocation.CheckedChanged
        If chkVocation.Checked = True AndAlso ddlCharJob.SelectedIndex > -1 Then
            ddlVocation.Visible = True
        Else
            ddlVocation.SelectedIndex = -1
            ddlVocation.Visible = False
        End If
    End Sub

    Private Function encode(ByVal instring As String) As String
        Dim enc As New System.Text.UnicodeEncoding
        Dim buffer As Byte() = enc.GetBytes(instring)
        encode = Convert.ToBase64String(buffer)
    End Function

    Private Function decode(ByVal instring As String) As String
        Dim enc As New System.Text.UnicodeEncoding
        Dim buffer As Byte() = Convert.FromBase64String(instring)
        decode = enc.GetString(buffer)
    End Function

#End Region

#Region "Scholar Handles"

    Private Sub SkillAnatomy_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillAnatomy.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillMysticism_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillMysticism.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillDemonAngelArts_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillDemonAngelArts.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillEleAttunement_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillEleAttunement.ValueChanged
        Select Case skillEleAttunement.Value
            Case 0
                ddlEleAttunement2.Visible = False
                ddlEleAttunement3.Visible = False
                ddlEleAttunement4.Visible = False
            Case 1
                ddlEleAttunement2.Visible = True
                ddlEleAttunement3.Visible = False
                ddlEleAttunement4.Visible = False
            Case 2
                ddlEleAttunement2.Visible = True
                ddlEleAttunement3.Visible = True
                ddlEleAttunement4.Visible = False
            Case 3
                ddlEleAttunement2.Visible = True
                ddlEleAttunement3.Visible = True
                ddlEleAttunement4.Visible = True
        End Select

        Recalc()
    End Sub
    Private Sub SkillFirstAid_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillFirstAid.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillNecroArts_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillNecroArts.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillPhysician_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillPhysician.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillReadAndWrite_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillReadAndWrite.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillReadMagic_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillReadMagic.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillReadMagicAvd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillReadMagicAvd.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillReadMagicRitual_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillReadMagicRitual.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillSphere1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSphere1.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillSphere2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSphere2.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillSphere3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSphere3.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillAdvRitual_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillAdvRitual.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillSpellRitual_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpellRitual.ValueChanged
        Recalc()
    End Sub

    Private Sub DDLSphere1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSphere1.SelectedIndexChanged
        If Race <> 808 Then
            ddlSphere2.Items.Clear()
            For i = 0 To ddlSphere1.Items.Count - 1
                ddlSphere2.Items.Add(ddlSphere1.Items(i))
            Next i
            ddlSphere2.Items.Remove(ddlSphere1.SelectedItem)
            ddlSphere3.Items.Remove(ddlSphere1.SelectedItem)

            If ddlSphere1.SelectedItem = "Elemental" Then
                ddlEleAttunement1.Visible = True
                ddlEleAttunement1.Location = New Point(32, ddlEleAttunement1.Location.Y)
            End If

            If ddlSphere1.SelectedItem <> "Elemental" AndAlso ddlSphere2.SelectedItem <> "Elemental" AndAlso ddlSphere3.SelectedItem <> "Elemental" Then
                ddlEleAttunement1.SelectedIndex = -1
                ddlEleAttunement1.Visible = False
            End If

            Recalc()
        End If
    End Sub

    Private Sub DDLSphere2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSphere2.SelectedIndexChanged
        ddlSphere3.Items.Clear()
        For i = 0 To ddlSphere2.Items.Count - 1
            ddlSphere3.Items.Add(ddlSphere2.Items(i))
        Next i
        ddlSphere3.Items.Remove(ddlSphere2.SelectedItem)
        ddlSphere3.Items.Remove(ddlSphere1.SelectedItem)

        If ddlSphere2.SelectedItem = "Elemental" Then
            ddlEleAttunement1.Visible = True
            ddlEleAttunement1.Location = New Point(186, ddlEleAttunement1.Location.Y)
        End If
        If ddlSphere1.SelectedItem <> "Elemental" AndAlso ddlSphere2.SelectedItem <> "Elemental" AndAlso ddlSphere3.SelectedItem <> "Elemental" Then
            ddlEleAttunement1.SelectedIndex = -1
            ddlEleAttunement1.Visible = False
        End If

        Recalc()
    End Sub

    Private Sub DDLSphere3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSphere3.SelectedIndexChanged

        If ddlSphere3.SelectedItem = "Elemental" Then
            ddlEleAttunement1.Visible = True
            ddlEleAttunement1.Location = New Point(342, ddlEleAttunement1.Location.Y)
        End If

        If ddlSphere1.SelectedItem <> "Elemental" AndAlso ddlSphere2.SelectedItem <> "Elemental" AndAlso ddlSphere3.SelectedItem <> "Elemental" Then
            ddlEleAttunement1.SelectedIndex = -1
            ddlEleAttunement1.Visible = False
        End If

        Recalc()
    End Sub

    Private Sub DDLEleAttunement1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlEleAttunement1.SelectedIndexChanged
        ddlEleAttunement2.Items.Add(ddlEleAttunement1.Items(0))
        ddlEleAttunement2.Items.Add(ddlEleAttunement1.Items(1))
        ddlEleAttunement2.Items.Add(ddlEleAttunement1.Items(2))
        ddlEleAttunement2.Items.Add(ddlEleAttunement1.Items(3))
        ddlEleAttunement2.Items.Remove(ddlEleAttunement1.SelectedItem)
        Recalc()
    End Sub

    Private Sub DDLEleAttunement2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlEleAttunement2.SelectedIndexChanged
        ddlEleAttunement3.Items.Add(ddlEleAttunement2.Items(0))
        ddlEleAttunement3.Items.Add(ddlEleAttunement2.Items(1))
        ddlEleAttunement3.Items.Add(ddlEleAttunement2.Items(2))
        ddlEleAttunement3.Items.Remove(ddlEleAttunement2.SelectedItem)
        Recalc()
    End Sub

    Private Sub DDLEleAttunement3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlEleAttunement3.SelectedIndexChanged
        ddlEleAttunement4.Items.Add(ddlEleAttunement3.Items(0))
        ddlEleAttunement4.Items.Add(ddlEleAttunement3.Items(1))
        ddlEleAttunement4.Items.Remove(ddlEleAttunement3.SelectedItem)
        Recalc()
    End Sub

    Private Sub DDLEleAttunement4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlEleAttunement4.SelectedIndexChanged
        Recalc()
    End Sub

    Private Sub ddlPyramid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPyramid.SelectedIndexChanged

        If ddlPyramid.SelectedIndex = 0 Then
            skillSpell1.Value = 0
            skillSpell2.Value = 0
            skillSpell3.Value = 0
            skillSpell4.Value = 0
            skillSpell5.Value = 0
            skillSpell6.Value = 0
            skillSpell7.Value = 0
            skillSpell8.Value = 0
            skillSpell9.Value = 0
        ElseIf ddlPyramid.SelectedIndex = 1 Then
            skillSpell1.Value = 1
            skillSpell2.Value = 0
            skillSpell3.Value = 0
            skillSpell4.Value = 0
            skillSpell5.Value = 0
            skillSpell6.Value = 0
            skillSpell7.Value = 0
            skillSpell8.Value = 0
            skillSpell9.Value = 0
        ElseIf ddlPyramid.SelectedIndex = 2 Then
            skillSpell1.Value = 2
            skillSpell2.Value = 1
            skillSpell3.Value = 0
            skillSpell4.Value = 0
            skillSpell5.Value = 0
            skillSpell6.Value = 0
            skillSpell7.Value = 0
            skillSpell8.Value = 0
            skillSpell9.Value = 0
        ElseIf ddlPyramid.SelectedIndex = 3 Then
            skillSpell1.Value = 3
            skillSpell2.Value = 2
            skillSpell3.Value = 1
            skillSpell4.Value = 0
            skillSpell5.Value = 0
            skillSpell6.Value = 0
            skillSpell7.Value = 0
            skillSpell8.Value = 0
            skillSpell9.Value = 0
        ElseIf ddlPyramid.SelectedIndex = 4 Then
            skillSpell1.Value = 4
            skillSpell2.Value = 3
            skillSpell3.Value = 2
            skillSpell4.Value = 1
            skillSpell5.Value = 0
            skillSpell6.Value = 0
            skillSpell7.Value = 0
            skillSpell8.Value = 0
            skillSpell9.Value = 0
        ElseIf ddlPyramid.SelectedIndex = 5 Then
            skillReadMagicAvd.Value = 1
            skillSpell1.Value = 5
            skillSpell2.Value = 4
            skillSpell3.Value = 3
            skillSpell4.Value = 2
            skillSpell5.Value = 1
            skillSpell6.Value = 0
            skillSpell7.Value = 0
            skillSpell8.Value = 0
            skillSpell9.Value = 0
        ElseIf ddlPyramid.SelectedIndex = 6 Then
            skillReadMagicAvd.Value = 1
            skillSpell1.Value = 5
            skillSpell2.Value = 5
            skillSpell3.Value = 4
            skillSpell4.Value = 3
            skillSpell5.Value = 2
            skillSpell6.Value = 1
            skillSpell7.Value = 0
            skillSpell8.Value = 0
            skillSpell9.Value = 0
        ElseIf ddlPyramid.SelectedIndex = 7 Then
            skillReadMagicAvd.Value = 1
            skillSpell1.Value = 5
            skillSpell2.Value = 5
            skillSpell3.Value = 5
            skillSpell4.Value = 4
            skillSpell5.Value = 3
            skillSpell6.Value = 2
            skillSpell7.Value = 1
            skillSpell8.Value = 0
            skillSpell9.Value = 0
        ElseIf ddlPyramid.SelectedIndex = 8 Then
            skillReadMagicAvd.Value = 1
            skillSpell1.Value = 5
            skillSpell2.Value = 5
            skillSpell3.Value = 5
            skillSpell4.Value = 5
            skillSpell5.Value = 4
            skillSpell6.Value = 3
            skillSpell7.Value = 2
            skillSpell8.Value = 1
            skillSpell9.Value = 0
        ElseIf ddlPyramid.SelectedIndex = 9 Then
            skillReadMagicAvd.Value = 1
            skillSpell1.Value = 5
            skillSpell2.Value = 5
            skillSpell3.Value = 5
            skillSpell4.Value = 5
            skillSpell5.Value = 5
            skillSpell6.Value = 4
            skillSpell7.Value = 3
            skillSpell8.Value = 2
            skillSpell9.Value = 1
        End If

        Recalc()
    End Sub

#End Region

#Region "Warrior Handles"
    Private Sub SkillFlorentine_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillFlorentine.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillFlurryOfBlows_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillFlurryOfBlows.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillHeavyArmour_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillHeavyArmour.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillSelfMut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSelfMut.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillShield_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillShield.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillSlayParry_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSlayParry.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillSlayParryMaster_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSlayParryMaster.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillSpecGroup_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpecGroup.ValueChanged
        Recalc()
    End Sub
    Private Sub skillSpecSpecific_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSpecSpecific.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillMedProf_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillMedProf.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillLargeProf_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillLargeProf.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillExoticProf_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillExoticProf.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillWeaponRefocus_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillWeaponRefocus.ValueChanged
        Recalc()
    End Sub
    Private Sub SkillAmbidexterity_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillAmbidexterity.ValueChanged
        Recalc()
    End Sub

    Private Sub DDLSlayParryWeapon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSlayParryWeapon.SelectedIndexChanged
        Recalc()
    End Sub

    Private Sub DDLSlayParryMasterWeapon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSlayParryMasterWeapon.SelectedIndexChanged
        Recalc()
    End Sub

    Private Sub DDLExoticWeapon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlExoticWeapon.SelectedIndexChanged
        Recalc()
    End Sub

    Private Sub DDLSpecSpecific_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSpecSpecific.SelectedIndexChanged
        Recalc()
    End Sub

#End Region

#Region "Rogue Handles"
    Private Sub SkillGarrote_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillGarrote.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillLocksmith_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Recalc()
    End Sub

    Private Sub SkillSap_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillSap.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillVitalBlow_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillVitalBlow.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillCritGroup_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillCritGroup.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillCritSpecific_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillCritSpecific.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillDodge_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillDodge.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillExecute_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillExecute.ValueChanged
        Recalc()
    End Sub

    Private Sub SkillExecuteMaster_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skillExecuteMaster.ValueChanged
        Recalc()
    End Sub

    Private Sub DDLSpecGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSpecGroup.SelectedIndexChanged
        Recalc()
    End Sub

    Private Sub DDLExecute_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlExecute.SelectedIndexChanged
        Recalc()
    End Sub

    Private Sub DDLExecuteMaster_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlExecuteMaster.SelectedIndexChanged
        Recalc()
    End Sub
    Private Sub DDLCritSpecificWeapon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlCritSpecificWeapon.SelectedIndexChanged
        Recalc()
    End Sub

    Private Sub DDLCritGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlCritGroup.SelectedIndexChanged
        Recalc()
    End Sub

#End Region
End Class