import pytest
from typing import Tuple
from datetime import timedelta, date

from app.model import Batch, OrderLine, allocate, OutOfStock

today = date.today()
tomorrow = today + timedelta(days=1)
next_week = today + timedelta(weeks=1)


def test_prefers_current_stock_batches_over_shipments():
    in_stock_batch = Batch("in-stock-batch", "RETRO-CLOCK", 100, eta=None)
    shipment_batch = Batch("shipment", "RETRO-CLOCK", 100, eta=tomorrow)
    line = OrderLine("oref", "RETRO-CLOCK", 10)

    allocate(line, [in_stock_batch, shipment_batch])

    assert in_stock_batch.available == 90
    assert shipment_batch.available == 100


def test_prefers_earlier_batch():
    today_batch = Batch("first", "SPOON", 100, eta=today)
    tomorrow_batch = Batch("second", "SPOON", 100, eta=tomorrow)
    next_week_batch = Batch("third", "SPOON", 100, eta=next_week)
    line = OrderLine("order1", "SPOON", 10)

    allocate(line, [today_batch, tomorrow_batch, next_week_batch])

    assert today_batch.available == 90
    assert tomorrow_batch.available == 100
    assert next_week_batch.available == 100


def test_returns_allocated_batch_ref():
    in_stock_batch = Batch("in-stock-ref", "WORLD-MAP", 100, eta=None)
    shipment_batch = Batch("shipment-ref", "WORLD-MAP", 100, eta=tomorrow)
    line = OrderLine("oref", "WORLD-MAP", 10)
    allocation = allocate(line, [in_stock_batch, shipment_batch])
    assert allocation == in_stock_batch.ref


def test_raises_out_of_stock_exception_if_cannot_allocate():
    batch = Batch("batch1", "FORK", 10, eta=today)
    allocate(OrderLine("order1", "FORK", 10), [batch])

    with pytest.raises(OutOfStock, match="FORK"):
        allocate(OrderLine("order1", "FORK", 10), [batch])
