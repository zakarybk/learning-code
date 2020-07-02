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
print(scientists)

fs = filter(lambda s: s.nobel is True, scientists)
print(next(fs))

print(tuple(filter(lambda s: s.nobel is True, scientists)))

def nobel_filter(x):
    return x.nobel is True

print(tuple(filter(nobel_filter, scientists)))

# Creates a generator 
pprint(tuple(x for x in scientists if x.nobel is True))
