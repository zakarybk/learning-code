from datetime import date
from typing import Optional, Set, Sequence, Any, Dict, List
from dataclasses import dataclass


class OutOfStock(Exception):
    pass


@dataclass(frozen=True)
class OrderLine:
    order_id: str
    sku: str
    qty: int


@dataclass
class Batch:
    ref: str
    sku: str
    stock: int
    eta: Optional[date]

    def __post_init__(self):
        self._allocations: Set[OrderLine] = set()

    def allocate(self, line: OrderLine):
        if self.can_allocate(line):
            self._allocations.add(line)

    def deallocate(self, line: OrderLine):
        if line in self._allocations:
            self._allocations.remove(line)

    @property
    def allocated(self) -> int:
        return sum(line.qty for line in self._allocations)

    @property
    def available(self) -> int:
        return self.stock - self.allocated

    def can_allocate(self, line: OrderLine) -> bool:
        return self.sku == line.sku and self.available >= line.qty
    
    def __eq__(self, other: Any):
        if not isinstance(other, type(self)):
            return False
        return other.ref == self.ref
    
    def __hash__(self):
        return hash(self.ref)
    
    def __gt__(self, other: Any):
        if self.eta is None:
            return False
        elif other.eta is None:
            return True
        return self.eta > other.eta


def allocate(line: OrderLine, batches: List[Batch]) -> str:
    try:
        batch = next(filter(
            lambda batch: batch.can_allocate(line),
            sorted(batches)
        ))
        batch.allocate(line)
        return batch.ref
    except StopIteration:
        raise OutOfStock(f"Out of stock for sku {line.sku}")


