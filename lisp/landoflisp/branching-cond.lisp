(defvar *arch-enemy* nil)
(defun pudding-eater (person)
  (cond ((eq person 'henry) (setf *arch-enemy* 'stupid-lisp-alien)
                            '(curse you lisp alien - you ate my pudding))
        ((eq person 'johnny) (setf *arch-enemy* 'unless-old-johnny)
                             '(i hope you chocked on my pudding johnny))
        (t                  '(why you eat my pudding stranger?))))

  (pudding-eater 'johnny)
