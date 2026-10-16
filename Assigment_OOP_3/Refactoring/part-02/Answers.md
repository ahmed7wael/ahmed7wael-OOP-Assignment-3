# Part 02 — answers

---

## Reports

- What was the problem? المشكلة هنا ان في كود متكرر كتير وفي كذا حته وهو هو بالضبط 
- What did you change? شيلت الحاجات المتكررة وحطيتها مرة واحدة في abstract class وخليت الباقي يورث منه ولو حاجه عايزة تعديل مختلف في كل كلاس خليها abstract method
- Why did you choose that approach? استخدمت abstract class علي ال interface عشان في shared code كتير وعايزه يتشارك بين كل ال classes وكمان عشان اقدر اعمل method abstract لو في حاجه محتاجه تعديل مختلف في كل class

---

## Enrollment

- What was the problem? المشكلة اني عندي خطوات لاتمام دفع الاوردر وهي خطوات ممكن تكون كتير وبتصعب الكود 
- What did you change? استخدمت ال Facade Design Pattern بحيث اني عملت كلاس كواجهة يسهل الكود علي ال user وجمعت فيه كل الكلاسات والفيتشرز اللي عاملها في باقي الكلاسات 
- Why did you choose that approach? لان كل كلاس بيعمل حاجه مختلفة مش متفقين علي حاجه واحدة وانا عايز حاجه تجمعهم في حته واحدة 
