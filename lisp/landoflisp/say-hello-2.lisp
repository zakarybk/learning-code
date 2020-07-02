(defun say-hello ()
  (princ "Please type your name:")
  (let ((name (read-line))) ;; read-line always string, read converts to type
    (princ "Nice to meet you, ")
    (princ name))) ;; princ doesn't add new lines

(say-hello)
