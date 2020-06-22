(defvar *arch-enemy* nil)
(defun pudding-eater (person)
  (case person
    ((henry)    (setf *arch-enemy* 'stupid-lisp-alien)
                '(curse you lis alient - you ate my pudding))
    ((johnny)   (setf *arch-enemy* 'unless-old-johnny)
                '(i hope you chocked on my pudding johnny))
    (otherwise '(why you eat my pudding stranger?))))
