<?php
    class professeur extends utilisateur{
        public $level;
        public $disponibility; # array
        public $school_subject; # array

        public function __construct($name, $lastname, $level, $disponibility, $school_subject){
                $this->setName($name);
                $this->setLastname($lastname);
                $this->setLevel($level);
                $this->setDisponibility($disponibility);
                $this->setSchoolSubject($school_subject);
        }

        public function getLevel(){
            return $this->level;
        }

        public function getDisponibility(){
            return $this->disponibility;
        }

        public function getSchoolSubject(){
            return $this->school_subject;
        }

        public function setLevel($level){
            return $this->level = $level;
        }

        public function setDisponibility($disponibility){
            return $this->disponibility = $disponibility;
        }

        public function setSchoolSubject($school_subject){
            return $this->school_subject = $school_subject;
        }
    }

?>