# looking words in parentheses using C#
### Menampilkan teks yang terdapat pada tanda kurung, dalam repo ini terdapat beberapa contoh
1. Menampilkan kata dalam teks yang hanya `terdapat 1 pasang tanda kurung` <br> <br> 
**Example:** Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat mengenali, meringkas, menerjemahkan, memprediksi, dan menghasilkan teks <br>   <br> 
    ```
    Output:
    LLM
    ```  
    <br>
 2. Menampilkan kada dalam text yang terdapat `lebih dari 1 pasang tanda kurung` <br> <br> 
**Example:**  Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat (mengenali), (meringkas), (menerjemahkan), (memprediksi), dan (menghasilkan teks) <br>   <br> 
    ```
    Output:
    -LLM
    -mengenali
    -meringkas
    -menerjemahkan
    -memprediksi
    -menghasilkan teks
    ```  
    <br>
 3. Menampilkan kata dalam text yang terdapat `pada tanda kurung lain di dalam tanda kurung` <br> <br> 
**Example:** Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu (program komputer yang dapat (1) mengenali, (2) meringkas, (3) menerjemahkan, (4) memprediksi, dan (5) menghasilkan teks) <br>   <br> 
    ```
    Output:
    -LLM
    -program komputer yang dapat (1) mengenali, (2) meringkas, (3) menerjemahkan, (4) memprediksi, dan (5) menghasilkan teks
    -1
    -2
    -3
    -4
    -5
    ```  
    <br>
    




