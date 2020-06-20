class Patron:

    def __init__(self, name):
        self.name = name

class FoodItem:

    def __init__(self, dishID):
        self.dishID = dishID

class KitchenSection:

    def PrepDish(self, dishID):
        raise NotImplemented

class Order:

    def __init__(self):
        self.appetiser = None
        self.entree = None
        self.drink = None

class ColdPrep(KitchenSection):

    def PrepDish(self, dishID):
        return FoodItem(dishID)

class HotPrep(KitchenSection):

    def PrepDish(self, dishID):
        return FoodItem(dishID)

class Bar(KitchenSection):

    def PrepDish(self, dishID):
        return FoodItem(dishID)

class Server:

    def __init__(self):
        self.coldPrep = ColdPrep()
        self.hotPrep = HotPrep()
        self.barPrep = Bar()

    def PlaceOrder(self, patren: Patron,
                            coldAppID: int,
                            hotEntreeID: int,
                            drinkID: int):
        print(f"{coldAppID} places order for cold app" +
                f", hot entree {hotEntreeID}" +
                f", and drink {drinkID}")

        order = Order()

        order.appetiser = self.coldPrep.PrepDish(coldAppID)
        order.entree = self.hotPrep.PrepDish(hotEntreeID)
        order.drink = self.barPrep.PrepDish(drinkID)

        return order

server = Server()
print("Hello! I#ll be your server today. What is your name?")
name = input()
patron = Patron(name)

print(f"Hello {patron.name}. What appetiser would you like? (1-15)")
appID = input()

print(f"That's a good one. What entree would you like? (1-15)")
entreeID = input()

print(f"A great choice! Finally, what drink would you like? (1-15)")
drinkID = input()

print("I'll get that order right away.")

# Here's what the Facade simplifies
server.PlaceOrder(patron, appID, entreeID, drinkID)

