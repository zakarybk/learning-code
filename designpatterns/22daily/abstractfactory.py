from abc import ABC, ABCMeta, abstractmethod

class Sandwich(ABC):
    pass

class Dessert(ABC):
    pass

class RecipeFactory(ABC):
    
    @abstractmethod
    def CreateSandwich(self):
        return Sandwich()

    @abstractmethod
    def CreateDessert(self):
        return Dessert()

class BLT(Sandwich):
    pass
class CremeBrulee(Dessert):
    pass

class AdultCuisineFactory(RecipeFactory):

    def CreateSandwich(self):
        return BLT()

    def CreateDessert(self):
        return CremeBrulee()

class GrilledCheese(Sandwich):
    pass
class IceCreamSandwich(Dessert):
    pass

class ChildCuisineFactory(RecipeFactory):

    def CreateSandwich(self):
        return GrilledCheese()

    def CreateDessert(self):
        return IceCreamSandwich()

print("Who are you? (A)dult or (C)hild?")
answer = input().upper()
factory = None #RecipeFactory() # Cannot create instance

if answer == 'A':
    factory = AdultCuisineFactory()
elif answer == 'C':
    factory = ChildCuisineFactory()
else:
    raise NotImplementedError

sandwich = factory.CreateSandwich()
dessert = factory.CreateDessert()

print("Sandwich: " + sandwich.__class__.__name__)
print("Dessert: " + dessert.__class__.__name__)

