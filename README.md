# Introduction

DateTimeOffset can be used to communicate towards API's. This solution contains 2 exactly the same (code wise) projects. 1 project is being build as .NET6 the other as .NET7. The endpoints both receive a DateTimeOffset and without processing/changing it, it is retourned to the caller.

# Problem

There is a difference between the parsing and displaying of the DateTimeOffset between .NET6 and .NET7. 
In .NET6 the datetimeoffset gets the datetimeoffset including offset (based on running machine's timezone) => Ex. Amsterdam Timezone = +0100
In .NET7 the datetimeoffset gets the UTC offset (+0000)

![Image](Screenshot_ResponseBody_Difference_between_framework_NET6_and_NET7.png)