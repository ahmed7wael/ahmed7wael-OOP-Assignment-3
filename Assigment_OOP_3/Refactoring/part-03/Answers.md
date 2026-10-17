# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(n^2)
- Time (ms) before: 12
- What did you change? خليت Contains تتعامل مع HashSet بدل List عشان HashSet lookup time O(1) بدل O(n) في ال List
- Time complexity after: O(n)
- Time (ms) after : 0

---

## Students

- What was the problem? المشكلة انه كان هيعمل مليون طالب وانا عايز 3 بس 
- What did you change? استخدمت ال lazy evaluation عن طريق ال yield return بدل ما اعمل list وارجعها كلها في الاخر
