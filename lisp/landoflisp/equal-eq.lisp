;;;; Use eq to compare symbols
;;;; Use equal for everything else
;;;; eql similar to eq, but also handles numbers and characters
;;;; equalp similar to equal, but also handles case differences and int/float

(defparameter *fruit* 'apple)

(cond ((eq *fruit* 'apple) 'its-an-apple)
      ((eq *fruit* 'orange) 'its-an-orange))

(equal 'apple 'apple)
(equal (list 1 2 3) (list 1 2 3))

(eql 'foo 'foo)
(eql 3.4 3.4)
(eql #\a #\a)

(equalp "Bob Smith" "bob smith")
(equalp 0 0.0)
