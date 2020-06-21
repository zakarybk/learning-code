class TemperatureType:
    Fahrenheit = 0
    Celsius = 1

class MeatDatabase:

    def GetSafeCookTemp(self, meat: str, tempType: TemperatureType):
        meat = meat.lower()
        safeTemp = None 
        if tempType == TemperatureType.Fahrenheit:
            safeTemp = 165
            if meat == "beef" or meat == "pork":
                safeTemp = 145
            elif meat == "chicken" or meat == "turkey":
                safeTemp = 165
        else:
            safeTemp = 74
            if meat == "beef" or meat == "pork" or meat == "veal":
                safeTemp = 63
            elif meat == "chicken" or meat == "turkey":
                safeTemp = 74
        return safeTemp

    def GetCaloriesPerOunce(self, meat: str):
        meat = meat.lower()
        calories = 0
        if meat == "beef":
            calories = 71
        elif meat == "pork":
            calories = 69
        elif meat == "chicken":
            calories = 66
        elif meat == "turkey":
            calories = 38
        return calories        

    def GetProteinPerOunce(self, meat: str):
        meat = meat.lower()
        protein = 0
        if meat == "beef":
            protein = 7.33
        elif meat == "pork":
            protein = 7.67
        elif meat == "chicken":
            protein = 8.57
        elif meat == "turkey":
            protein = 8.5
        return protein

# New code below, old (legacy) above
class Meat:

    def __init__(self, meat: str):
        self.meatName = meat

        self.safeCookTempFahrenheit = None
        self.safeCookTempCelsius = None
        self.caloriesPerOunce = None
        self.proteinPerOunce = None
        
    def LoadData(self):
        print(f"Meat: {self.meatName}")

class MeatDetails(Meat):

    def __init__(self, name):
        super().__init__(name)

    def LoadData(self):
        meatDatabase = MeatDatabase()

        self.safeCookTempFahrenheit = meatDatabase.GetSafeCookTemp(
            self.meatName,
            TemperatureType.Fahrenheit
        )
        self.safeCookTempCelsius = meatDatabase.GetSafeCookTemp(
            self.meatName,
            TemperatureType.Celsius
        )
        self.caloriesPerOunce = meatDatabase.GetCaloriesPerOunce(self.meatName)
        self.proteinPerOunce = meatDatabase.GetProteinPerOunce(self.meatName)

        super().LoadData()
        print(f"Safe Cook Temp (F): {self.safeCookTempFahrenheit}")
        print(f"Safe Cook Temp (C): {self.safeCookTempCelsius}")
        print(f"Calories per Ounce: {self.caloriesPerOunce}")
        print(f"Protein per Ounce: {self.proteinPerOunce}")

unknown = Meat("Beef")
unknown.LoadData()
print("---")

beef = MeatDetails("Beef")
beef.LoadData()
print("---")

turkey = MeatDetails("Turkey")
turkey.LoadData()
print("---")

chicken = MeatDetails("Chicken")
chicken.LoadData()


            
