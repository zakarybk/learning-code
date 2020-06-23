class Bread: # abstract class

    def MixIngredients(self):
        raise NotImplementedError

    def Bake(self):
        raise NotImplemetedError

    def Slice(self):
        print(f"Slicing the {self.__class__.__name__} bread!")

    def Make(self):
        self.MixIngredients()
        self.Bake()
        self.Slice()

class TwelveGrain(Bread):

    def MixIngredients(self):
        print("Gathering Ingredients for 12-Grain Bread.")

    def Bake(self):
        print("Baking the 12-Grain Bread. (25 minutes)")

class Sourdough(Bread):

    def MixIngredients(self):
        print("Gathering Ingredients for Sourdough Bread.")

    def Bake(self):
        print("Baking the Sourdough Bread. (20 minutes)")

class WholeWheat(Bread):

    def MixIngredients(self):
        print("Gathering Ingredients for Whole Wheat Bread.")

    def Bake(self):
        print("Baking the Whole Wheat Bread. (15 minutes)")

sourdough = Sourdough()
sourdough.Make()

twelveGrain = TwelveGrain()
twelveGrain.Make()

wholeWheat = WholeWheat()
wholeWheat.Make()
