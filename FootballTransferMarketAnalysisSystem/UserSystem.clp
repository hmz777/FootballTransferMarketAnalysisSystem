(deffunction FilterByPlaystyle (?Pos ?PlayStyle ?average_scores)

   (if (eq ?Pos GK) then
      (if (eq ?PlayStyle Tiki-Taka) 
      then        
         (do-for-all-facts ((?p player)) (not (and (>= ?p:gk_speed (fact-slot-value ?average_scores avg_gk_speed)) (>= ?p:gk_handling (fact-slot-value ?average_scores avg_gk_handling))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Counter-Attack) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:gk_speed (fact-slot-value ?average_scores avg_gk_speed)) (>= ?p:gk_reflexes (fact-slot-value ?average_scores avg_gk_reflexes)) (>= ?p:gk_kicking (fact-slot-value ?average_scores avg_gk_kicking))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Park-The-Bus)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:gk_reflexes (fact-slot-value ?average_scores avg_gk_reflexes)) (>= ?p:gk_diving (fact-slot-value ?average_scores avg_gk_diving)) (>= ?p:gk_handling (fact-slot-value ?average_scores avg_gk_handling))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Long-Ball)
      then
        (do-for-all-facts ((?p player)) (not (>= ?p:gk_kicking (fact-slot-value ?average_scores avg_gk_kicking)))
         (retract ?p))
      )
   )   
   (if (or (eq ?Pos CB) (eq ?Pos LCB) (eq ?Pos RCB) (eq ?Pos LB) (eq ?Pos RB)) then
      (if (eq ?PlayStyle Tiki-Taka) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:defending (fact-slot-value ?average_scores avg_defending)) (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:skill_long_passing (fact-slot-value ?average_scores avg_skill_long_passing))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Counter-Attack) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:defending (fact-slot-value ?average_scores avg_defending)) (>= ?p:defending_sliding_tackle (fact-slot-value ?average_scores avg_defending_sliding_tackle)) (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:movement_sprint_speed (fact-slot-value ?average_scores avg_movement_sprint_speed))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Park-The-Bus)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:defending (fact-slot-value ?average_scores avg_defending)) (>= ?p:defending_sliding_tackle (fact-slot-value ?average_scores avg_defending_sliding_tackle)) (>= ?p:defending_standing_tackle (fact-slot-value ?average_scores avg_defending_standing_tackle)) (>= ?p:skill_ball_control (fact-slot-value ?average_scores avg_skill_ball_control))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Long-Ball)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:skill_long_passing (fact-slot-value ?average_scores avg_skill_long_passing))))
         (retract ?p))
      )
      (if (eq ?PlayStyle High-Press)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:defending (fact-slot-value ?average_scores avg_defending)) (>= ?p:defending_sliding_tackle (fact-slot-value ?average_scores avg_defending_sliding_tackle)) (>= ?p:mentality_interceptions (fact-slot-value ?average_scores avg_mentality_interceptions))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Classic)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:defending (fact-slot-value ?average_scores avg_defending))))
         (retract ?p))
      )
   ) 
   (if (or (eq ?Pos CDM) (eq ?Pos LDM) (eq ?Pos RDM) (eq ?Pos LWB) (eq ?Pos RWB)) then

      (if (eq ?PlayStyle Tiki-Taka) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:dribbling (fact-slot-value ?average_scores avg_dribbling)) (>= ?p:skill_dribbling (fact-slot-value ?average_scores avg_skill_dribbling)) (>= ?p:skill_long_passing (fact-slot-value ?average_scores avg_skill_long_passing)) (>= ?p:skill_ball_control (fact-slot-value ?average_scores avg_skill_ball_control))))
         (retract ?p))
      )

      (if (eq ?PlayStyle Counter-Attack) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:movement_sprint_speed (fact-slot-value ?average_scores avg_movement_sprint_speed))))
         (retract ?p))
      )

      (if (eq ?PlayStyle Park-The-Bus)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:defending (fact-slot-value ?average_scores avg_defending)) (>= ?p:defending_standing_tackle (fact-slot-value ?average_scores avg_defending_standing_tackle))))
         (retract ?p))
      )

      (if (eq ?PlayStyle Long-Ball)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:skill_long_passing (fact-slot-value ?average_scores avg_skill_long_passing)) (>= ?p:skill_ball_control (fact-slot-value ?average_scores avg_skill_ball_control))))
         (retract ?p))
      )

      (if (eq ?PlayStyle High-Press)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:defending (fact-slot-value ?average_scores avg_defending)) (>= ?p:defending_sliding_tackle (fact-slot-value ?average_scores avg_defending_sliding_tackle)) (>= ?p:mentality_interceptions (fact-slot-value ?average_scores avg_mentality_interceptions))))
         (retract ?p))
      )

      (if (eq ?PlayStyle Classic)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:defending (fact-slot-value ?average_scores avg_defending))))
         (retract ?p))
      )
   ) 
   (if (or (eq ?Pos CM) (eq ?Pos LCM) (eq ?Pos RCM) (eq ?Pos LM) (eq ?Pos RM)) then
       (if (eq ?PlayStyle Tiki-Taka) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:dribbling (fact-slot-value ?average_scores avg_dribbling)) (>= ?p:skill_dribbling (fact-slot-value ?average_scores avg_skill_dribbling)) (>= ?p:skill_long_passing (fact-slot-value ?average_scores avg_skill_long_passing)) (>= ?p:skill_ball_control (fact-slot-value ?average_scores avg_skill_ball_control))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Counter-Attack) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:movement_acceleration (fact-slot-value ?average_scores avg_movement_acceleration)) (>= ?p:attacking_short_passing (fact-slot-value ?average_scores avg_attacking_short_passing)) (>= ?p:movement_sprint_speed (fact-slot-value ?average_scores avg_movement_sprint_speed))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Park-The-Bus)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:skill_ball_control (fact-slot-value ?average_scores avg_skill_ball_control))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Long-Ball)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:skill_long_passing (fact-slot-value ?average_scores avg_skill_long_passing)) (>= ?p:skill_ball_control (fact-slot-value ?average_scores avg_skill_ball_control))))
         (retract ?p))
      )
      (if (eq ?PlayStyle High-Press)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:defending_sliding_tackle (fact-slot-value ?average_scores avg_defending_sliding_tackle)) (>= ?p:mentality_interceptions (fact-slot-value ?average_scores avg_mentality_interceptions))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Classic)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:defending_standing_tackle (fact-slot-value ?average_scores avg_defending_standing_tackle))))
         (retract ?p))
      )
   ) 
   (if (or (eq ?Pos CAM) (eq ?Pos LAM) (eq ?Pos RAM) (eq ?Pos LW) (eq ?Pos RW)) then
      (if (eq ?PlayStyle Tiki-Taka) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:dribbling (fact-slot-value ?average_scores avg_dribbling)) (>= ?p:skill_dribbling (fact-slot-value ?average_scores avg_skill_dribbling)) (>= ?p:skill_ball_control (fact-slot-value ?average_scores avg_skill_ball_control))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Counter-Attack) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:pace (fact-slot-value ?average_scores avg_pace)) (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:attacking_crossing (fact-slot-value ?average_scores avg_attacking_crossing)) (>= ?p:attacking_short_passing (fact-slot-value ?average_scores avg_attacking_short_passing)) (>= ?p:movement_acceleration (fact-slot-value ?average_scores avg_movement_acceleration)) (>= ?p:movement_sprint_speed (fact-slot-value ?average_scores avg_movement_sprint_speed))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Park-The-Bus)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:defending_standing_tackle (fact-slot-value ?average_scores avg_defending_standing_tackle))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Long-Ball)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:skill_long_passing (fact-slot-value ?average_scores avg_skill_long_passing)) (>= ?p:skill_ball_control (fact-slot-value ?average_scores avg_skill_ball_control))))
         (retract ?p))
      )
      (if (eq ?PlayStyle High-Press)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:defending_standing_tackle (fact-slot-value ?average_scores avg_defending_standing_tackle)) (>= ?p:defending_sliding_tackle (fact-slot-value ?average_scores avg_defending_sliding_tackle)) (>= ?p:mentality_interceptions (fact-slot-value ?average_scores avg_mentality_interceptions))))
         (retract ?p))
      )
      (if (eq ?PlayStyle Classic)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:skill_ball_control (fact-slot-value ?average_scores avg_skill_ball_control))))
         (retract ?p))
      )
   ) 
   (if (or (eq ?Pos CF)(eq ?Pos LCF)(eq ?Pos RCF)(eq ?Pos ST)) then
      (if (eq ?PlayStyle Tiki-Taka) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:dribbling (fact-slot-value ?average_scores avg_dribbling)) (>= ?p:skill_dribbling (fact-slot-value ?average_scores avg_skill_dribbling)) (>= ?p:skill_long_passing (fact-slot-value ?average_scores avg_skill_long_passing)) (>= ?p:skill_ball_control (fact-slot-value ?average_scores avg_skill_ball_control))))
         (retract ?p))
      )

      (if (eq ?PlayStyle Counter-Attack) 
      then 
         (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:attacking_crossing (fact-slot-value ?average_scores avg_attacking_crossing)) (>= ?p:attacking_short_passing (fact-slot-value ?average_scores avg_attacking_short_passing)) (>= ?p:movement_acceleration (fact-slot-value ?average_scores avg_movement_acceleration)) (>= ?p:movement_sprint_speed (fact-slot-value ?average_scores avg_movement_sprint_speed))))
         (retract ?p))
      )

      (if (eq ?PlayStyle Park-The-Bus)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:defending_standing_tackle (fact-slot-value ?average_scores avg_defending_standing_tackle))))
         (retract ?p))
      )

      (if (eq ?PlayStyle Long-Ball)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:passing (fact-slot-value ?average_scores avg_passing)) (>= ?p:skill_long_passing (fact-slot-value ?average_scores avg_skill_long_passing))))
         (retract ?p))
      )

      (if (eq ?PlayStyle High-Press)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:defending_sliding_tackle (fact-slot-value ?average_scores avg_defending_sliding_tackle)) (>= ?p:mentality_interceptions (fact-slot-value ?average_scores avg_mentality_interceptions))))
         (retract ?p))
      )

      (if (eq ?PlayStyle Classic)
      then
        (do-for-all-facts ((?p player)) (not (and (>= ?p:physic (fact-slot-value ?average_scores avg_physic)) (>= ?p:attacking_crossing (fact-slot-value ?average_scores avg_attacking_crossing))))
         (retract ?p))
      )
   ) 
)

(deffunction CalculateAverageScores (?Position)

   (bind ?count (length$ (find-all-facts ((?players player)) (neq ?players:long_name none))))

   (if (eq ?Position GK) 
   then

      (bind ?gk_diving 0)
      (bind ?gk_handling 0)
      (bind ?gk_kicking 0)
      (bind ?gk_reflexes 0)
      (bind ?gk_speed 0)

      (do-for-all-facts ((?p player)) (neq ?p:long_name none)
         (bind ?gk_diving (+ ?gk_diving ?p:gk_diving))
         (bind ?gk_handling (+ ?gk_handling ?p:gk_handling))
         (bind ?gk_kicking (+ ?gk_kicking ?p:gk_kicking))
         (bind ?gk_reflexes (+ ?gk_reflexes ?p:gk_reflexes))
         (bind ?gk_speed (+ ?gk_speed ?p:gk_speed))
      )

      (assert (average_scores 
            (avg_gk_diving (/ ?gk_diving ?count))
            (avg_gk_handling (/ ?gk_handling ?count))
            (avg_gk_kicking (/ ?gk_kicking ?count))
            (avg_gk_reflexes (/ ?gk_reflexes ?count))
            (avg_gk_speed (/ ?gk_speed ?count))
      ))

   else
   
      (bind ?skill_moves 0)
      (bind ?pace 0)
      (bind ?shooting 0)
      (bind ?passing 0)
      (bind ?dribbling 0)
      (bind ?defending 0)
      (bind ?physic 0)
      (bind ?attacking_crossing 0)
      (bind ?attacking_finishing 0)
      (bind ?attacking_heading_accuracy 0)
      (bind ?attacking_short_passing 0)
      (bind ?attacking_volleys 0)
      (bind ?skill_dribbling 0)
      (bind ?skill_long_passing 0)
      (bind ?skill_ball_control 0)
      (bind ?movement_acceleration 0)
      (bind ?movement_sprint_speed 0)
      (bind ?movement_agility 0)
      (bind ?power_shot_power 0)
      (bind ?power_long_shots 0)
      (bind ?mentality_aggression 0)
      (bind ?mentality_interceptions 0)
      (bind ?defending_standing_tackle 0)
      (bind ?defending_sliding_tackle 0)

      (do-for-all-facts ((?p player)) (neq ?p:long_name none)
      
         (bind ?skill_moves (+ ?skill_moves ?p:skill_moves))
         (bind ?pace (+ ?pace ?p:pace))
         (bind ?shooting (+ ?shooting ?p:shooting))
         (bind ?passing (+ ?passing ?p:passing))
         (bind ?dribbling (+ ?dribbling ?p:dribbling))
         (bind ?defending (+ ?defending ?p:defending))
         (bind ?physic  (+ ?physic ?p:physic))
         (bind ?attacking_crossing  (+ ?attacking_crossing ?p:attacking_crossing))
         (bind ?attacking_finishing  (+ ?attacking_finishing ?p:attacking_finishing))
         (bind ?attacking_heading_accuracy  (+ ?attacking_heading_accuracy ?p:attacking_heading_accuracy))
         (bind ?attacking_short_passing  (+ ?attacking_short_passing ?p:attacking_short_passing))
         (bind ?attacking_volleys  (+ ?attacking_volleys ?p:attacking_volleys))
         (bind ?skill_dribbling  (+ ?skill_dribbling ?p:skill_dribbling))
         (bind ?skill_long_passing  (+ ?skill_long_passing ?p:skill_long_passing))
         (bind ?skill_ball_control  (+ ?skill_ball_control ?p:skill_ball_control))
         (bind ?movement_acceleration  (+ ?movement_acceleration ?p:movement_acceleration))
         (bind ?movement_sprint_speed  (+ ?movement_sprint_speed ?p:movement_sprint_speed))
         (bind ?movement_agility  (+ ?movement_agility ?p:movement_agility))
         (bind ?power_shot_power  (+ ?power_shot_power ?p:power_shot_power))
         (bind ?power_long_shots  (+ ?power_long_shots ?p:power_long_shots))
         (bind ?mentality_aggression   (+ ?mentality_aggression ?p:mentality_aggression))
         (bind ?mentality_interceptions  (+ ?mentality_interceptions ?p:mentality_interceptions))
         (bind ?defending_standing_tackle  (+ ?defending_standing_tackle ?p:defending_standing_tackle))
         (bind ?defending_sliding_tackle  (+ ?defending_sliding_tackle ?p:defending_sliding_tackle))
      )
      
      (assert (average_scores 
            (avg_skill_moves (/ ?skill_moves ?count))
            (avg_pace (/ ?pace ?count))
            (avg_shooting (/ ?shooting ?count))
            (avg_passing (/ ?passing ?count))
            (avg_dribbling (/ ?dribbling ?count))
            (avg_defending (/ ?defending ?count))
            (avg_physic (/ ?physic ?count))
            (avg_attacking_crossing (/ ?attacking_crossing ?count))
            (avg_attacking_finishing (/ ?attacking_finishing ?count))
            (avg_attacking_heading_accuracy (/ ?attacking_heading_accuracy ?count))
            (avg_attacking_short_passing (/ ?attacking_short_passing ?count))
            (avg_attacking_volleys (/ ?attacking_volleys ?count))
            (avg_skill_dribbling (/ ?skill_dribbling ?count))
            (avg_skill_long_passing (/ ?skill_long_passing ?count))
            (avg_skill_ball_control (/ ?skill_ball_control ?count))
            (avg_movement_acceleration (/ ?movement_acceleration ?count))
            (avg_movement_sprint_speed (/ ?movement_sprint_speed ?count))
            (avg_movement_agility (/ ?movement_agility ?count))
            (avg_power_shot_power (/ ?power_shot_power ?count))
            (avg_power_long_shots (/ ?power_long_shots ?count))
            (avg_mentality_aggression (/ ?mentality_aggression ?count))
            (avg_mentality_interceptions (/ ?mentality_interceptions ?count))
            (avg_defending_standing_tackle (/ ?defending_standing_tackle ?count))
            (avg_defending_sliding_tackle (/ ?defending_sliding_tackle ?count))
      ))
   )
)

(defrule filter-by-age
  (declare (salience 1000))
  ?players <- (player (age ?age))
  (MaxAge ?MaxAge)
  (test (> ?age ?MaxAge))
    => (retract ?players)
)

(defrule filter-by-position
 (declare (salience 900))
  ?players <- (player (player_positions $?player_positions) (team_position ?team_position) (nation_position ?nation_position))
  (Position ?Position)
  (test (and (not (member$ ?Position ?player_positions)) (neq ?Position ?team_position) (neq ?Position ?nation_position)))
    => (retract ?players)
)

(defrule filter-by-preferred-foot
 (declare (salience 800))
  ?players <- (player (preferred_foot ?preferred_foot))
  (PreferredFoot ?PreferredFoot)
  (test (neq ?preferred_foot ?PreferredFoot))
    => (retract ?players)
)

(defrule filter-by-marketvalue
(declare (salience 700))
  ?players <- (player (value_eur ?value_eur))
  (MaxMarketValue ?MaxMarketValue)
  (test (> ?value_eur ?MaxMarketValue))
    => (retract ?players)
)

(defrule filter-by-potential
(declare (salience 600))
  ?players <- (player (potential ?potential))
  (MaxPotential ?MaxPotential)
    (test (> ?potential ?MaxPotential))
    => (retract ?players)
)

(defrule calculate-average-scores
   (declare (salience 500))
   (Position ?Position)
   =>    
   (CalculateAverageScores ?Position)
)

(defrule filter-by-PlayStyle
 (declare (salience 400))
  (Position ?Position)
  (PlayStyle ?PlayStyle)
  ?average_scores <- (average_scores)
=> (FilterByPlaystyle ?Position ?PlayStyle ?average_scores)
)

(defrule result
 (declare (salience 300))
=>   
    (do-for-all-facts ((?p player)) (neq ?p:long_name none)
       (printout t (implode$ ?p:long_name) "#" ?p:age "#" (implode$ ?p:nationality) "#" (implode$ ?p:club_name) "#" ?p:potential "#" ?p:value_eur "/"))
)