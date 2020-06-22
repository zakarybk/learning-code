(if (= (+ 1 2) 3)
  'yup
  'nope)

(if '(1)
  'the-list-has-stuff-in-it
  'the-list-is-empty)

(defvar *number-was-odd* nil)

(if (oddp 5)
  (progn (setf *number-was-odd* t)
         'odd-number)
  'even-number)

