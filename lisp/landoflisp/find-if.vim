(find-if #'oddp '(2 4 5 6))

(if (find-if #'oddp '(2 4 5 6))
    'there-is-an-odd-number
    'there-is-no-odd-number)

(find-if #'null '(2 4 nil 6))
