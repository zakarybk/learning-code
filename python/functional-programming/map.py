import collections
from pprint import pprint

Scientist = collections.namedtuple('Scientist', [
    'name',
    'field',
    'born',
    'nobel'
])

scientists = (
    Scientist(name='Ada Lovelace', field='math', born=1815, nobel=False),
    Scientist(name='Emmy Noether', field='math', born=1882, nobel=False),
    Scientist(name='Marie Curi', field='physics', born=1867, nobel=True)
)    

def filter_name_and_age(x):
    return {'name': x.name, 'age': 2020 - x.born}

names_and_ages = tuple(map(filter_name_and_age, scientists))
pprint(names_and_ages)

pprint(tuple({'name': x.name, 'age': 2020 - x.born} for x in scientists))
