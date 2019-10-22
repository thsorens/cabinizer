(ns raffle.subs
  (:require
    [re-frame.core :as rf]))

(rf/reg-sub
  ::items
  (fn [db _]
    (get db :items [])))
