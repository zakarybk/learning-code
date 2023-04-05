import pytest
from typing import Tuple
from datetime import date

from app.model import Batch, OrderLine


def test_allocating_to_a_batch_reduces_the_available_quanitity():
    batch = Batch("batch-001", "SMALL-BOX", stock=20, eta=date.today())
    line = OrderLine("order-ref", "SMALL-BOX", 2)

    batch.allocate(line)

    assert batch.available == 18


def make_batch_and_line(sku: str, batch_stock: int, line_qty: int) -> Tuple[Batch, OrderLine]:
    return (
        Batch("batch-001", sku, batch_stock, eta=date.today()),
        OrderLine("order-123", sku, line_qty)
    )


def test_can_allocate_if_available_greater_than_required():
    large_batch, small_line = make_batch_and_line("SOCKS", 20, 2)
    assert large_batch.can_allocate(small_line)


def test_cannot_allocate_if_available_smaller_than_required():
    small_batch, large_line = make_batch_and_line("SOCKS", 2, 20)
    assert not small_batch.can_allocate(large_line)


def test_can_allocate_if_available_equal_to_required():
    equal_batch, equal_line = make_batch_and_line("SOCKS", 2, 2)
    assert equal_batch.can_allocate(equal_line)


def test_cannot_allocate_if_skus_do_not_match():
    batch = Batch("batch-001", "BLUE-PEN", 100, eta=None)
    different_sku_line = OrderLine("order-123", "BLACK-PEN", 10)
    assert not batch.can_allocate(different_sku_line)


def test_can_only_deallocate_allocated_lines():
    batch, unallocated_line = make_batch_and_line("PIZZA-OVEN", 20, 2)
    batch.deallocate(unallocated_line)
    assert batch.available == 20


def test_allocation_is_idempotent():
    batch, line = make_batch_and_line("BEANS", 20, 2)
    batch.allocate(line)
    batch.allocate(line)
    assert batch.available == 18
