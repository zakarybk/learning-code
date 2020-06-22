class IOrderingSystem:  # Interface

    def Place(self, order: str):
        raise NotImplementedError

class SendOrder:    # Abstract class

    def __init__(self):
        self.restaurant = None

    def Send(self):
        raise NotImplementedError

class SendDairyFreeOrder(SendOrder):

    def Send(self):
        self.restaurant.Place("Dairy-Free Order")

class SendGlutenFreeOrder(SendOrder):

    def Send(self):
        self.restaurant.Place("Gluten-Free Order")

class DinnerOrders(IOrderingSystem):

    def Place(self, order: str):
        print(f"Placing order for {order} at the Diner.")

class FancyRestaurantOrders(IOrderingSystem):

    def Place(self, order: str):
        print(f"Placing order for {order} at the Fancy Restaurant.")

sendOrder = SendDairyFreeOrder()
sendOrder.restaurant = DinnerOrders()
sendOrder.Send()

sendOrder.restaurant = FancyRestaurantOrders()
sendOrder.Send()

sendOrder = SendGlutenFreeOrder()
sendOrder.restaurant = DinnerOrders()
sendOrder.Send()

sendOrder.restaurant = FancyRestaurantOrders()
sendOrder.Send()

