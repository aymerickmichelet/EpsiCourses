<?php

    class utilisateur {
        protected $name;
        protected $lastname;
        
        public function getName(){
            return $this->name;
        }
        
        public function getLastname(){
            return $this->lastname;
        }
        
        public function setName($name){
            $this->name = $name;
        }
        
        public function setLastname($lastname){
            $this->lastname = $lastname;
        }
        
    }
?>