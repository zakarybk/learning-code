(defun add-five ()
  (print "please entre a number:")
  (let ((num (read)))
    (print "When I add five I get")
    (print (+ num 5))))

(add-five)
