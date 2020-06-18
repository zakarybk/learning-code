from abc import ABC, ABCMeta, abstractmethod

class Ingredient(ABC):
    pass

class Bread(Ingredient):
    pass
class Turkey(Ingredient):
    pass
class Lettuce(Ingredient):
    pass
class Mayonnaise(Ingredient):
    pass


class Sandwich(ABC):
   
    def __init__(self):
        self.ingredients = self.CreateIngredients()
        super().__init__() # Not called

    @abstractmethod
    def CreateIngredients(self):
        return []


class TurkeySandwich(Sandwich):
    def __init__(self):
        super().__init__() # Not called

    def CreateIngredients(self):
        self.ingredients = []
        self.ingredients.append(Bread())
        self.ingredients.append(Mayonnaise())
        self.ingredients.append(Lettuce())
        self.ingredients.append(Turkey())
        self.ingredients.append(Turkey())
        self.ingredients.append(Bread())
        return len(self.ingredients)

turkeySandwich = TurkeySandwich().CreateIngredients()
num = turkeySandwich
print(f"This sandwich has {num} ingredients!")
