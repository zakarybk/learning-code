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

    @abstractmethod
    def CreateIngredients(self):
        return []


class TurkeySandwich(Sandwich):

    def CreateIngredients(self):
        ingredients = []
        ingredients.append(Bread())
        ingredients.append(Mayonnaise())
        ingredients.append(Lettuce())
        ingredients.append(Turkey())
        ingredients.append(Turkey())
        ingredients.append(Bread())
        return ingredients

turkeySandwich = TurkeySandwich()
num = len(turkeySandwich.ingredients)
print(f"This sandwich has {num} ingredients!")

