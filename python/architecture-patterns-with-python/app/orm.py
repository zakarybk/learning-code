from sqlalchemy.orm import mapper, relationship
from sqlalchemy import MetaData, Table, Integer, String, Column

import model


metadata = MetaData()


order_lines = Table(
    'order_lines', metadata,
    Column('id', Integer, primary_key=True, autoincrement=True),
    Column('sku', String(255)),
    Column('qty', Integer, nullable=False),
    Column('order_id', String(255))
)

def start_mappers():
    lines_mapper = mapper(model.OrderLine, order_lines)

