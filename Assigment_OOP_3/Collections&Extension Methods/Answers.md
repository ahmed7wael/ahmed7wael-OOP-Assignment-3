
# Collections Research — Answers

1. **What is each one?**
   - IReadOnlyDictionary: ده interface بيخليني اتعامل عادي مهع ال Dictionary بس من غير ما اقدر اعدل علي ال data اللي جواه يعني read only - مفيش Add or remove
   - SortedDictionary: ده dictionary بيخزن ال data بتاعته في ترتيب معين based on the key يعني لو انا عندي keys 1, 3, 2 هيخزنهم كده 1, 2, 3

2. **How is IReadOnlyDictionary different from Dictionary, and why would a public method return one instead of a Dictionary?**
   - Difference: الفرق ان ال IReadOnlyDictionary مش هقدر اعدل علي ال data اللي جواه يعني read only - اما ال Dictionary اقدر اعمل Add or remove
   - Why return IReadOnlyDictionary: لو عندي معلومات مهمة عن users وعايز احافظ عليها محدش يغير حاجه من بره تكون للقراءة فقط 

3. **How is SortedDictionary different from Dictionary in ordering and in lookup speed?**
   - Ordering: ال SortedDictionary بيخزن ال data بتاعته في ترتيب معين based on the key يعني لو انا عندي keys 1, 3, 2 هيخزنهم كده 1, 2, 3 - اما ال Dictionary مش بيهتم بالترتيب
   - Lookup speed: sortedDictionary lookup time O(log n) - اما ال Dictionary lookup time O(1) on average

4. **When would you choose SortedDictionary?**
   -عايز ترتيب ال data based on the key 
   - عايز اعمل range queries علي ال data based on the key
   - ممكن استغني حاجه بسيطة عن ال lookup time O(1) عشان احصل علي ترتيب معينز

======================================================================================================
# Task 2.2 — Pick the Collection

- **S1:** `Dictionary`
  - Reason: لان انا هنا عايز ابحث عن طريق Key واللي هو NationalId وعايز اعمل Lookup time O(1) on average

- **S2:** `HashSet`
  - Reason: هنا طبعا كان عايز عدم تكرار فا انسب حاجه هتبقي HashSet عشان Lookup time O(1) on average

- **S3:** `List`
  - Reason: طبعا هنا List عشان بتحافظ علي ترتيب دخول القيم وكمان بتسمح بالتكرار عادي 

- **S4:** `IReadOnlyDictionary`
  - Reason: هنا طبعا IReadOnlyDictionary لانها بتسمح بالرؤية فقط ومفيهاش تعديل خالص ولا Remove ولا حتي Add

- **S5:** `SortedDictionary`
  - Reason: هنا كان عايز ترتيب للوقت عشان استخدمنا SortedDictionary

- **S6:** `IEnumerable`
  - Reason: هنا كنا عايزين Lazy Evaluation عشان نقدر نعمل Loop علي ال data من غير ما نعمل List كلها في الذاكرة

