import collections
from functools import reduce
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

total_age = reduce(
        lambda acc, val: acc + val['age'],
        names_and_ages,
        0)

print(total_age)

print(sum(x['age'] for x in names_and_ages))

def reducer(acc, val):
    acc[val.field].append(val.name)
    return acc

scientists_by_field = reduce(
        reducer,
        scientists,
        {'math': [], 'physics': [], 'chemistry': [], 'astronomy': []}
        )

pprint(scientists_by_field)
