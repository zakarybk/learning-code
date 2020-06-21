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

    def GetProteinPerOunce(meat: str):
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

            
