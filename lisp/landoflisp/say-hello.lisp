(defun say-hello()
  (print "Please type your name:")
  (let ((name (read)))
    (prin1 "Nice to meet you, ")
    (prin1 name)))

(say-hello)
