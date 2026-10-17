# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem? دلوقتي لو حبيت ازود طريقة شحن جديدة هضطر اعدل في الكود كله وهنا بي violate OCP principle
- What did you change? عملت interface وخليت كل نوع من الشركات ي implement بحيث اني لو زودت حاجه مش هدخل اعدل في الكلاس الاساسي لا انا هعمل كلاس جديد بس وي implement interface 

---

## OrderProcessor

- What was the problem? violate DIP dependency inversion principle - ولو عايز ازود اي حاجه بعدين مش هعدل في كذا حته 
- What did you change? عملت interface عشان اعمل مبدا ال adstaction وبعدين خليت  low level تعتمد علي ال interface وكذلك ال high level تعتمد علي ال interface وده هيخلي الكود اسهل في التعديل والتطوير وكمان هيخلي الكود اسهل في الفهم

---

## Notifications

- What was the problem? المشكلة هنا الوراثة هتزيد ولو حبيت ازود مثلا واتساب نتوفيكيشن هزود معاه كذا كلاس كمان وهنا الوراثة مش حلو وهيعملنا مشاكل وكمان بي violate LSP
- What did you change? استبدلت ال inheritance بال composition وده هيخلي الكود اسهل في التعديل والتطوير وكمان هيخلي الكود اسهل في الفهم

---

## Proof


- New carrier file(s): UPSShippingCostCalculator
- New notification channel file(s): WhatsUpNotification
- Existing classes left unchanged? (yes/no): yes عشان اتبعنا OCP principle
