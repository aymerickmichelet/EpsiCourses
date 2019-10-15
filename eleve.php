<?php
    class eleve extends utilisateur{
        public $level;

        public function __construct($name, $lastname, $level){
            $this->setName($name);
            $this->setLastname($lastname);
            $this->setLevel($level);
        }

        public function getLevel(){
            return $this->level;
        }

        public function setLevel($level){
            $this->level = $level;
        }
    }

?>