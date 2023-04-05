# from app.orm import model
from app import model 

def test_orderline_mapper_can_load_lines(session):
    session.execute(
        "INSERT INTO order_lines (order_id, sku, qty) VALUES "
        "('order1', 'RED-CHAIR', 2),"
        "('order1', 'BLACK-CHAIR', 4),"
        "('order1', 'BLUE-CHAIR', 6)"
    )
    expected = [
        model.OrderLine('order1', 'RED-CHAIR', 2),
        model.OrderLine('order1', 'BLACK-CHAIR', 4),
        model.OrderLine('order1', 'BLUE-CHAIR', 6)
    ]
    assert session.query(model.OrderLine).all() == expected


def test_orderline_mapper_can_save_lines(session):
    new_line = model.OrderLine('order1', 'STEAM-DECK', 1)
    session.add(new_line)
    session.commit()

    rows = list(session.execute("SELECT order_id, sku, qty FROM 'order_lines'"))
    assert rows == [('order1', 'STEAM-DECK', 1)]