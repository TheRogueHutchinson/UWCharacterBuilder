### Initial Set Costs from File

mercenary_costs = {}
with open("mercenary_costs.txt") as f:
    for line in f:
        (key, val) = line.split(",")
        mercenary_costs[key] = val

ranger_costs = {}
with open("ranger_costs.txt") as f:
    for line in f:
        (key, val) = line.split(",")
        ranger_costs[key] = val

templar_costs = {}
with open("templar_costs.txt") as f:
    for line in f:
        (key, val) = line.split(",")
        templar_costs[key] = val

nightblade_costs = {}
with open("nightblade_costs.txt") as f:
    for line in f:
        (key, val) = line.split(",")
        nightblade_costs[key] = val

assassin_costs = {}
with open("assassin_costs.txt") as f:
    for line in f:
        (key, val) = line.split(",")
        assassin_costs[key] = val

witchhunter_costs = {}
with open("witchhunter_costs.txt") as f:
    for line in f:
        (key, val) = line.split(",")
        witchhunter_costs[key] = val

mage_costs = {}
with open("mage_costs.txt") as f:
    for line in f:
        (key, val) = line.split(",")
        mage_costs[key] = val

druid_costs = {}
with open("druid_costs.txt") as f:
    for line in f:
        (key, val) = line.split(",")
        druid_costs[key] = val

bard_costs = {}
with open("bard_costs.txt") as f:
    for line in f:
        (key, val) = line.split(",")
        bard_costs[key] = val

### Create Form View

from kivy.app import App
from kivy.uix.gridlayout import GridLayout
from kivy.uix.boxlayout import BoxLayout
from kivy.uix.label import Label
from kivy.uix.textinput import TextInput
from kivy.uix.button import Button
from kivy.uix.dropdown import DropDown

class MainWindow(BoxLayout):
    def __init__(self, **kwargs):
        super(MainWindow, self).__init__(**kwargs)
        self.orientation = 'horizontal'
        overview = OverviewScreen()
        self.add_widget(overview)
        self.add_widget(Button(text='Skills', size_hint=(.9,1)))

        

class OverviewScreen(BoxLayout):
    def __init__(self, **kwargs):
        super(OverviewScreen, self).__init__(**kwargs)
        self.orientation = 'vertical'
        
        self.add_widget(Label(text='Player Name'))
        self.p_name = TextInput(multiline=False)
        self.add_widget(self.p_name)
        
        self.add_widget(Label(text='Character Name'))
        self.c_name = TextInput(multiline=False)
        self.add_widget(self.c_name)

        self.add_widget(Label(text='Race'))
        self.race_dropdown = DropDown()
        race_list = []
        with open("races.txt") as f:
            for line in f:
                race_list.append(line)
        for index in race_list:
            btn = Button(text=index, size_hint_y=None, height=30)
            btn.bind(on_release=lambda btn: self.race_dropdown.select(btn.text))
            self.race_dropdown.add_widget(btn)
        self.race_mainbutton = Button(text='Races')
        self.race_mainbutton.bind(on_release=self.race_dropdown.open)
        self.race_dropdown.bind(on_select=lambda instance, x: setattr(self.race_mainbutton, 'text', x))
        self.add_widget(self.race_mainbutton)

        self.add_widget(Label(text='Occupation'))
        self.occupation_dropdown = DropDown()
        occupation_list = []
        with open("occupations.txt") as f:
            for line in f:
                occupation_list.append(line)
        for index in occupation_list:
            btn = Button(text=index, size_hint_y=None, height=30)
            btn.bind(on_release=lambda btn: self.occupation_dropdown.select(btn.text))
            self.occupation_dropdown.add_widget(btn)
        self.occupation_mainbutton = Button(text='Occupations')
        self.occupation_mainbutton.bind(on_release=self.occupation_dropdown.open)
        self.occupation_dropdown.bind(on_select=lambda instance, x: setattr(self.occupation_mainbutton, 'text', x))
        self.add_widget(self.occupation_mainbutton)
        

class ProductionSkillsScreen(GridLayout):
    def __init__(self, **kwargs):
        super(ProductionSkillsScreen, self).__init__(**kwargs)
        self.cols = 4
        self.add_widget(Label(text='User Name'))
        self.username = TextInput(multiline=False)
        self.add_widget(self.username)
        self.add_widget(Label(text='password'))
        self.password = TextInput(password=True, multiline=False)
        self.add_widget(self.password)


class BuilderApp(App):
    def build(self):
        return MainWindow()


if __name__ == '__main__':
    BuilderApp().run()










































