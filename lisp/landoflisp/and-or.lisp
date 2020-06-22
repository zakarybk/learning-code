(and (oddp 5) (oddp 7) (oddp 9))

(or (oddp 4) (oddp 7) (oddp 8))

(defparameter *is-it-even* nil)
(or (oddp 4) (setf *is-it-even* t))
(or (oddp 5) (setf *is-it-even* t))

(if *file-modified*
  (if (ask-user-about-saving)
    (save-file)))
(and *file-modified* (ask-user-about-saving) (save-file))
(if (and *file-modified*
         (ask-user-about-saving))
  (save-file))

